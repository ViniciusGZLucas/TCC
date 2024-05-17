using Domain.Interface.BusinessRule.ArticleSchedule;
using Domain.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TCC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleScheduleController : BaseController
    {
        public readonly IArticleScheduleBusinessRule _articlescheduleBusinessRule;

        public ArticleScheduleController(IArticleScheduleBusinessRule articlescheduleBusinessRule)
        {
            _articlescheduleBusinessRule = articlescheduleBusinessRule;
        }

        [AllowAnonymous]
        [HttpPost("Create")]
        public IActionResult Create([FromBody] InputCreateArticleScheduleViewModel viewModel)
        {
            var dto = _articlescheduleBusinessRule.Create(_dataSession, viewModel);

            return Ok(dto.Id);
        }
    }
}
