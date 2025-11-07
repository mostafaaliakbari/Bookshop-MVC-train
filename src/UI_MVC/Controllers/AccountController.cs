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

        [HttpPost]    //اینو ببرسی کن
        public IActionResult Login(string username, string password)
        {
            User user = _userService.Login(username, password);
            if (user != null)
            {
               
                if (user.Role == Role.ادمین)
                {
                    return RedirectToAction("Dashboard", "Account");

                }
                else
                    return RedirectToAction("BookList", "Book");


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


        [HttpGet]
        public IActionResult List()
        {
      
            var Users = _userService.GetUsers();
            return View(Users);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
     

            var user = _userService.GetById(id);
            if (user == null) return NotFound();

            return View(user);
        }

        [HttpPost]
        public IActionResult Update(User user)
        {
     

            _userService.Update(user);
            return RedirectToAction("List");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
           
            _userService.Delete(id);
            return RedirectToAction("List");
        }


        [HttpGet]
        public IActionResult Dashboard()
        {
      
            return View();
        }


    }
}
