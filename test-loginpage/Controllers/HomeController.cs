using Microsoft.AspNetCore.Mvc;

namespace test_loginpage.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet("GetData")]
        public IActionResult GetData(string hello)
        {
            hello = "Hello World";
            return Content(hello);
        }
    }
}


