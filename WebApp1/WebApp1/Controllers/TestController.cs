using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class TestControllerBase : ControllerBase
    {
        // This method leads to failing nullable ref validation
        protected ObjectResult StatusCode(int statusCode, string detail) => Problem(detail, statusCode: statusCode);
        
        [HttpGet("base")]
        public IActionResult GetBase(string value)
        {
            return Ok($"Success: {value}");
        }
    }
    
    public class TestController : TestControllerBase
    {
        [HttpGet("own")]
        public IActionResult GetOwn(string value)
        {
            return Ok($"Success: {value}");
        }
    }
}