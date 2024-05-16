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

        [AllowAnonymous]
        [HttpPost("Create")]
        public IActionResult Create([FromBody]InputCreateArticleViewModel viewModel)
        {
            var dto = _articleBusinessRule.Create(_dataSession, viewModel);

            return Ok(1);
        }

        [AllowAnonymous]
        [HttpPost("LinkDocument")]
        public IActionResult LinkDocument([FromForm]InputLinkArticleDocumentViewModel viewModel)
        {
            return Ok();
        }
    }
}
