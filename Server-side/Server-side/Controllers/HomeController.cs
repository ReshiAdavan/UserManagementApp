using Microsoft.AspNetCore.Mvc;

namespace TUT2022.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
