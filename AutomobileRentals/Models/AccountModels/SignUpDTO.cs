using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AutomobileRentals.Models.AccountModels
{
    public class SignUpDTO : AccountBaseDTO
    {
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string IdentityNumber { get; set; }
      
    }
}
