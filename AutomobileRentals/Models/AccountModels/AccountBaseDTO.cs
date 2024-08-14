using System.ComponentModel.DataAnnotations;

namespace AutomobileRentals.Models.AccountModels
{
    public class AccountBaseDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
