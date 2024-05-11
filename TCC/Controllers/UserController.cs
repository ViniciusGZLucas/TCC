using Domain.Interface.BusinessRule;
using Domain.ViewModel;
using Domain.ViewModel.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TCC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : BaseController
    {
        public readonly IUserBusinessRule _userBusinessRule;

        public UserController(IUserBusinessRule userBusinessRule)
        {
            _userBusinessRule = userBusinessRule;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserLoginViewModel userLoginViewModel)
        {
            var populateToken = _userBusinessRule.Login(userLoginViewModel.Email, userLoginViewModel.Password);
            return Ok(populateToken);
        }

        [Authorize]
        [HttpPost("Create")]
        public IActionResult Create(InputCreateUserViewModel viewModel)
        {
            var dto = _userBusinessRule.Create(_dataSession, viewModel);

            return Ok(dto);
        }
    }
}
