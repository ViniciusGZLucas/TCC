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
        [HttpPost("SendTestMail")]
        public async Task<IActionResult> SendTestMail()
        {
            await EmailService.Test();

            return Ok(true);
        }
    }
}
