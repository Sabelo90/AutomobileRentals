using AutomobileRentals.Models.AccountModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AutomobileRentals.Contracts
{
    public interface IAccountService
    {
        Task<IEnumerable<IdentityError>> SignUpAsync(SignUpDTO signUpDTO);
        Task<SignInResultDTO> SignInAsync(SignInDTO signInDTO);
    }
}
