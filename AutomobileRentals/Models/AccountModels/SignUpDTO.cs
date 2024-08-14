using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AutomobileRentals.Models.AccountModels
{
    public class SignUpDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string IdentityNumber { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
