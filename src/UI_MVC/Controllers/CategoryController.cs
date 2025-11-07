using Microsoft.AspNetCore.Mvc;

namespace UI_MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService = new CategoryService();
        [HttpGet]
        public IActionResult List()
        {
            //int? Roleint = HttpContext.Session.GetInt32("Role");
            //if (Roleint != 1 || Roleint == null) {
            //    return RedirectToAction("login","Account");
            //}
            var listCategory = _categoryService.GetCategories();
            return View(listCategory);
        }

        [HttpGet]
        public IActionResult Delete(int categoryId)
        {
            //int? Roleint = HttpContext.Session.GetInt32("Role");
            //if (Roleint != 1 || Roleint == null)
            //{
            //    return RedirectToAction("login", "Account");
            //}
            _categoryService.Delete(categoryId);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            //int? Roleint = HttpContext.Session.GetInt32("Role");
            //if (Roleint != 1 || Roleint == null)
            //{
            //    return RedirectToAction("login", "Account");
            //}
            var category= _categoryService.GetCategory(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            _categoryService.Update(category);
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult CreateCategory(string Title)
        {
            _categoryService.Create(Title);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Create()
        {
            //int? Roleint = HttpContext.Session.GetInt32("Role");
            //if (Roleint != 1 || Roleint == null)
            //{
            //    return RedirectToAction("login", "Account");
            //}
            return View();
        }
    }
}
