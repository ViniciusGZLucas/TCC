using CrossCutting.Services.EmailService;
using CrossCutting.Services.TokenService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TCC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        [Authorize]
        [HttpGet("Test")]
        public IActionResult Test()
        {
            return Ok(true);
        }

        [AllowAnonymous]
        [HttpGet("GetToken")]
        public IActionResult GetToken()
        {
            var populateToken = new PopulateToken(true, new List<string> { "programador", "admin" });

            return Ok(TokenService.GenerateToken(populateToken));
        }

        [AllowAnonymous]
        [HttpPost("SendTestMail")]
        public IActionResult SendTestMail()
        {
            EmailService.Test();

            return Ok(true);
        }
    }
}
