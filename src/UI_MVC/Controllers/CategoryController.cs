using Microsoft.AspNetCore.Mvc;

namespace UI_MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService = new CategoryService();
        [HttpGet]
        public IActionResult List()
        {
            var listCategory = _categoryService.GetCategories();
            return View(listCategory);
        }

        [HttpGet]
        public IActionResult Delete(int categoryId)
        {
            _categoryService.Delete(categoryId);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
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
            return View();
        }
    }
}
