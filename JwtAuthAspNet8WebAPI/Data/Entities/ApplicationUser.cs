using Microsoft.AspNetCore.Identity;

namespace JwtAuthAspNet8WebAPI.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
