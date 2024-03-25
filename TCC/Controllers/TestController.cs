using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TCC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        [Authorize]
        [HttpGet]
        public IActionResult Test()
        {
            return Ok(true);
        }
    }
}
