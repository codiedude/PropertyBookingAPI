using Microsoft.AspNetCore.Identity;

namespace PropertyBookingAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
