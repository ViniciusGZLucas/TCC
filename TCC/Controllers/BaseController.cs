using CrossCutting.DataSession;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IdentityModel.Tokens.Jwt;

namespace TCC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController : Controller
    {
        protected DataSession _dataSession;

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if(context.Exception != null)
            {
                context.Result = BadRequest(context.Exception?.Message);

                context.Exception = null;
            }

            base.OnActionExecuted(context);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var token = Request.Headers.Authorization.FirstOrDefault()?.Replace("Bearer ", "");

            if (string.IsNullOrEmpty(token))
                return;

            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);

            var newDataSession = new DataSession();

            foreach (var property in typeof(DataSession).GetProperties())
            {
                var value = jwtSecurityToken.Payload.Where(x => x.Key == property.Name).FirstOrDefault().Value;

                if (property.PropertyType == typeof(List<string>))
                    value = value.ToString()?.Split(',').ToList();

                property.SetValue(newDataSession, Convert.ChangeType(value, property.PropertyType));
            }

            _dataSession = newDataSession;

            base.OnActionExecuting(context);
        }
    }
}
