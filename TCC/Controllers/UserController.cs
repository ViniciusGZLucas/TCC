using Domain.Interface.BusinessRule;
using Domain.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TCC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        public readonly IUserBusinessRule _userBusinessRule;

        public UserController(IUserBusinessRule userBusinessRule)
        {
            _userBusinessRule = userBusinessRule;
        }

        [Authorize]
        [HttpPost("Create")]
        public IActionResult Create(UserViewModel viewModel)
        {
            var dto = _userBusinessRule.Create(viewModel);

            return Ok(dto);
        }
    }
}
