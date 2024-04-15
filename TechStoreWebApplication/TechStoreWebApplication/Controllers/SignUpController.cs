namespace TechStoreWebApplication.Controllers
{
    #region
    using Microsoft.AspNetCore.Mvc;
    #endregion
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string username, string password, string email, string address, string name)
        {
            if (IsUsernameAvailable(username))
            {
                return Content($"User registered: Username - {username}, Password - {password}, Email - {email}, Address - {address}, Name - {name}");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Username is already taken.");
                return View("Index");
            }
        }
        private bool IsUsernameAvailable(string username)
        {
            return username != "admin";
        }
    }
}
