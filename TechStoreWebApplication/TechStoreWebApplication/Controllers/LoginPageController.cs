namespace TechStoreWebApplication.Controllers
{
    #region
    using Microsoft.AspNetCore.Mvc;
    #endregion
    
        public class LoginPageController : Controller
        {
            public IActionResult Login()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Login(string username, string password)
            {
                if (IsValidUser(username, password))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                    return View();
                }
            }

            private bool IsValidUser(string username, string password)
            {
                return (username == "admin" && password == "password");
            }
        }
    }

