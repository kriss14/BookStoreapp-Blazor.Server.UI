using Microsoft.AspNetCore.Identity;

namespace BookStoreApp_Blazor.Server.UI.Data
{
    public class AppUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
