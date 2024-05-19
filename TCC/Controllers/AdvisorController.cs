using Domain.Interface.BusinessRule;
using Domain.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TCC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdvisorController : BaseController
    {
        public readonly IAdvisorBusinessRule _advisorBusinessRule;

        public AdvisorController(IAdvisorBusinessRule advisorBusinessRule)
        {
            _advisorBusinessRule = advisorBusinessRule;
        }

        [Authorize]
        [HttpPost("Create")]
        public IActionResult Create([FromBody] InputCreateAdvisorViewModel viewModel)
        {
            var dto = _advisorBusinessRule.Create(_dataSession, viewModel);

            return Ok(dto.Id);
        }
    }
}
