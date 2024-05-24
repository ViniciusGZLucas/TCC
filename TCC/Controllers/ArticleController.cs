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
        public IActionResult Create([FromBody] InputCreateArticleViewModel viewModel)
        {
            var dto = _articleBusinessRule.Create(_dataSession, viewModel);

            return Ok(dto.Id);
        }

        [Authorize]
        [HttpPost("LinkDocument")]
        public IActionResult LinkDocument([FromForm] InputLinkArticleDocumentViewModel viewModel)
        {
            _articleBusinessRule.LinkDocument(_dataSession, viewModel);

            return Ok();
        }

        [Authorize]
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var listDTO = _articleBusinessRule.GetAll(_dataSession);

            return Ok(listDTO);
        }

        [Authorize]
        [HttpGet("GetByAuthorId")]
        public IActionResult GetByAuthorId()
        {
            var dto = _articleBusinessRule.GetByAuthorId(_dataSession);

            return Ok(dto);
        }

        [Authorize]
        [HttpGet("GetById/{articleId}")]
        public IActionResult GetById([FromRoute] long articleId)
        {
            var dto = _articleBusinessRule.GetById(_dataSession, articleId);

            return Ok(dto);
        }

        [Authorize]
        [HttpDelete("Delete/{articleId}")]
        public IActionResult Delete([FromRoute] long articleId)
        {
            _articleBusinessRule.Delete(_dataSession, articleId);

            return Ok();
        }

        [Authorize]
        [HttpPost("Accept/{articleId}")]
        public IActionResult Accept([FromRoute] long articleId)
        {
            _articleBusinessRule.Accept(_dataSession, articleId);

            return Ok();
        }

        [Authorize]
        [HttpPost("GetDocument/{articleId}")]
        public IActionResult GetDocument([FromRoute] long documentId)
        {
            return Ok(_articleBusinessRule.GetDocument(_dataSession, documentId));
        }
    }
}
