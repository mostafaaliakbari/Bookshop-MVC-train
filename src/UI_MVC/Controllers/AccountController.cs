using Microsoft.AspNetCore.Mvc;

namespace UI_MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService = new UserService();
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            User user = _userService.Login(username, password);
            if (user != null)
            {
                if (user.Role == Role.ادمین)
                {
                    return RedirectToAction("List", "Category");
                }

            }

            ViewData["Error"] = "نام کاربری یا پسورد اشتباست";
            return View();

        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            _userService.Create(user);
            return RedirectToAction("Login");
        }


    }
}
