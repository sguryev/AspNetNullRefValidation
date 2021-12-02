using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class TestControllerBase : ControllerBase
    {
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