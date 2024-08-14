using Microsoft.AspNetCore.Identity;

namespace AutomobileRentals.EntityFramework.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
    }

}
