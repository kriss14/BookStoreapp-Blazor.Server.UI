using AutoMapper;
using BookStoreApp_Blazor.Server.UI.Models.User;
using BookStoreApp_Blazor.Server.UI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp_Blazor.Server.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> logger;
        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;

        public AuthController(ILogger<AuthController> logger, IMapper mapper, UserManager<AppUser> userManager)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(UserDto userDto)
        {
            logger.LogInformation($"Registratio Attempt for {userDto.Email}");

            try
            {
                var user = mapper.Map<AppUser>(userDto);
                user.UserName = userDto.Email;
                var result = await userManager.CreateAsync(user, userDto.Password);

                if (result.Succeeded == false)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return BadRequest(ModelState);
                }


                await userManager.AddToRoleAsync(user, "User");
                return Accepted();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Oops something wrong in the {nameof(Register)}");
                return Problem($"Oops something wrong in the {nameof(Register)}", statusCode: 500);
            }



        }


        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginUserDto userDto)
        {
            logger.LogInformation($"Login Attempt for {userDto.Email}");
            try
            {
                var user = await userManager.FindByEmailAsync(userDto.Email);
                var passwordValid = await userManager.CheckPasswordAsync(user, userDto.Password);
                if (user == null || passwordValid == false)
                {
                    return NotFound();
                }

                return Accepted();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Oops something wrong in the {nameof(Register)}");
                return Problem($"Oops something wrong in the {nameof(Register)}", statusCode: 500);
            }
        }

    }
}

