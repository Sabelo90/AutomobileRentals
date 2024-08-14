using AutoMapper;
using AutomobileRentals.Contracts;
using AutomobileRentals.EntityFramework.Data;
using AutomobileRentals.EntityFramework.Models;
using AutomobileRentals.Models.AccountModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AutomobileRentals.Services
{
    public class AccountService : IAccountService
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AccountService(AppDbContext appDbContext, UserManager<User> userManager, IMapper mapper, IConfiguration configuration)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<SignInResultDTO> SignInAsync(SignInDTO signInDTO)
        {
            var user = await _userManager.FindByEmailAsync(signInDTO.Email);
            if (user is null)
            {
                return  null;
            }

            var isValidPassword = await _userManager.CheckPasswordAsync(user, signInDTO.Password);
            if (!isValidPassword)
            {
                return null;
            }

            var token = await GenerateToken(user);

            return new SignInResultDTO
            {
                userId = user.Id,
                Name = user.FirstName + " " + user.LastName,
                Token = token
            };
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


        #region HelperMethods
        private async Task<string> GenerateToken(User user)
        {
            var signCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtToken:Key"])), SecurityAlgorithms.HmacSha256);
            var roles = await _userManager.GetRolesAsync(user);
            var roleClaims = roles.Select(s => new Claim(ClaimTypes.Role, s)).ToList();
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub , user.Email),
                new Claim(JwtRegisteredClaimNames.Jti , Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email , user.Email),
            }.Union(roleClaims);

            var token = new JwtSecurityToken(
                signingCredentials: signCredentials
                , claims: claims,
                expires: DateTime.Now.AddMinutes(int.Parse(_configuration["JwtToken:Duration"])));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        #endregion

    }
}
