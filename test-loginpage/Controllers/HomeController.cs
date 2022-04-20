using Microsoft.AspNetCore.Mvc;

namespace test_loginpage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
