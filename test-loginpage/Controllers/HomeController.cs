using Microsoft.AspNetCore.Mvc;

namespace test_loginpage.Controllers
{
    //[Route("api/controller")]
    //[ApiController]
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("GetData")]
        public IActionResult GetData()
        {
            string hello = "Hello World";
            return Ok(hello);
        }

        
    }
}


