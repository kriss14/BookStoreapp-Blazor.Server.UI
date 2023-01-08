﻿using System.ComponentModel.DataAnnotations;

namespace BookStoreApp_Blazor.Server.UI.Models.User
{
    public class UserDto:LoginUserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Role { get; set; }

    }
}