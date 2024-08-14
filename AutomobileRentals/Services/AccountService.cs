using AutoMapper;
using AutomobileRentals.Contracts;
using AutomobileRentals.EntityFramework.Data;
using AutomobileRentals.EntityFramework.Models;
using AutomobileRentals.Models.AccountModels;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AutomobileRentals.Services
{
    public class AccountService : IAccountService
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public AccountService(AppDbContext appDbContext , UserManager<User> userManager , IMapper mapper )
        {
            _appDbContext = appDbContext;
             _userManager = userManager;
            _mapper = mapper;
        }
        public async Task<IEnumerable<IdentityError>> SignUpAsync(SignUpDTO signUpDTO)
        {
            var user = _mapper.Map<User>(signUpDTO);
            user.UserName = signUpDTO.Email;
            var result = await _userManager.CreateAsync(user, signUpDTO.Password);

            if (result.Succeeded)
            {
                _ = await _userManager.AddToRoleAsync(user, "Client");
            }

            return result.Errors;
        }
    }
}
