using AutomobileRentals.Contracts;
using AutomobileRentals.Models.AccountModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AutomobileRentals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("signup")]
        public async Task<ActionResult<IEnumerable<IdentityError>>> SignUpAsync(SignUpDTO SignUpDTO)
        {
            var result = await _accountService.SignUpAsync(SignUpDTO);
            return Ok(result);
        }

    }

}
