using AutoMapper;
using BookStoreApp_Blazor.Server.UI.Models.User;
using BookStoreApp_Blazor.Server.UI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using Microsoft.IdentityModel.JsonWebTokens;
using BookStoreApp_Blazor.Server.UI.Static;
using System.IdentityModel.Tokens.Jwt;
using System.Configuration;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;
using Microsoft.AspNetCore.Authorization;

namespace BookStoreApp_Blazor.Server.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> logger;
        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;
        private readonly IConfiguration configuration;

        public AuthController(ILogger<AuthController> logger, IMapper mapper, UserManager<AppUser> userManager, IConfiguration configuration)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.userManager = userManager;
            this.configuration = configuration;
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
        public async Task<ActionResult<AuthResponse>> Login(LoginUserDto userDto)
        {
            logger.LogInformation($"Login Attempt for {userDto.Email}");
            try
            {
                var user = await userManager.FindByEmailAsync(userDto.Email);
                var passwordValid = await userManager.CheckPasswordAsync(user, userDto.Password);
                if (user == null || passwordValid == false)
                {
                    return Unauthorized(userDto);
                }

                string tokenString = await GenerateToken(user);
                var response = new AuthResponse
                {
                    Email = userDto.Email,
                    Token = tokenString,
                    UserId = user.Id,
                };
                return response;
                    
                                }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Oops something wrong in the {nameof(Register)}");
                return Problem($"Oops something wrong in the {nameof(Register)}", statusCode: 500);
            }
        }

        private async Task<string> GenerateToken(AppUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var roles = await userManager.GetRolesAsync(user);
            var roleClaims = roles.Select(q => new Claim(ClaimTypes.Role, q)).ToList();
            var userClaims = await userManager.GetClaimsAsync(user);
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(CustomClaimTypes.Uid, user.Id)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var token = new JwtSecurityToken(
                issuer: configuration["JwtSettings:Issuer"],
                audience: configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(Convert.ToInt32(configuration["JwtSettings:Duration"])),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

