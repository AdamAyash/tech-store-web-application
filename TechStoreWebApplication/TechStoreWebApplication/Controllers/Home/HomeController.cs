using Microsoft.AspNetCore.Mvc;

namespace TechStoreWebApplication.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
