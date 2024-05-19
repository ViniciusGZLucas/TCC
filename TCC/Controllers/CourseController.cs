using Domain.Interface.BusinessRule;
using Domain.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TCC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : BaseController
    {
        public readonly ICourseBusinessRule _courseBusinessRule;

        public CourseController(ICourseBusinessRule courseBusinessRule)
        {
            _courseBusinessRule = courseBusinessRule;
        }

        [Authorize]
        [HttpPost("Create")]
        public IActionResult Create([FromBody] InputCreateCourseViewModel viewModel)
        {
            var dto = _courseBusinessRule.Create(_dataSession, viewModel);

            return Ok(dto.Id);
        }
    }
}
