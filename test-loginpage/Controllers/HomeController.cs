using Microsoft.AspNetCore.Mvc;
using test_loginpage.Models;

namespace test_loginpage.Controllers
{
    //[Route("api/controller")]
    //[ApiController]
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetData")]
        public IActionResult GetData()
        {
            string hello = "Hello World";
            return Ok(hello);
        }


        [HttpGet]
        [Route("GetDatabaseData")]
        public IActionResult GetDatabaseData()
        {
            dataAccess da = new dataAccess(_configuration);

            List<UserInfo> returnedData = da.UserSelect();

            return Ok(returnedData);


            

        }

        
    }
}


