using System.ComponentModel.DataAnnotations;

namespace BookStoreApp_Blazor.Server.UI.Models.User
{
    public class LoginUserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}