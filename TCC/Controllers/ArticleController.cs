using Domain.Interface.BusinessRule;
using Domain.ViewModel.Article;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TCC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : BaseController
    {
        public readonly IArticleBusinessRule _articleBusinessRule;

        public ArticleController(IArticleBusinessRule articleBusinessRule)
        {
            _articleBusinessRule = articleBusinessRule;
        }

        [Authorize]
        [HttpPost("Create")]
        public IActionResult Create(InputCreateArticleViewModel viewModel)
        {
            var dto = _articleBusinessRule.Create(_dataSession, viewModel);

            return Ok(dto);
        }
    }
}
