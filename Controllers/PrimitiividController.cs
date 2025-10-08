using Microsoft.AspNetCore.Mvc;

namespace veeb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PrimitiividController : ControllerBase
    {

        // GET: primitiivid/hello-world
        [HttpGet("hello-world")]
        public string HelloWorld()
        {
            return "Hello world at " + DateTime.Now;
        }

    }
}