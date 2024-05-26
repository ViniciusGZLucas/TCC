using Domain.Interface.BusinessRule;
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
            var dto = _userBusinessRule.Login(userLoginViewModel.Email, userLoginViewModel.Password);

            return Ok(dto);
        }

        [AllowAnonymous]
        [HttpPost("Create")]
        public IActionResult Create(InputCreateUserViewModel viewModel)
        {
            var dto = _userBusinessRule.Create(_dataSession, viewModel);

            return Ok(dto);
        }

        [Authorize]
        [HttpGet("GetLoggedUser")]
        public IActionResult GetLoggedUser()
        {
            var dto = _userBusinessRule.GetLoggedUser(_dataSession);

            return Ok(dto);
        }
    }
}
