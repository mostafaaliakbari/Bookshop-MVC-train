using Microsoft.AspNetCore.Mvc;
using UI_MVC.Entitis;
using UI_MVC.Models;

namespace UI_MVC.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly ICategoryService _categoryService;

        public BookController()
        {
            _bookService = new BookService();
            _categoryService = new CategoryService();
        }

        public IActionResult BookList()
        {
            var model = new BooklistViewModel
            {
                Books = _bookService.GetBooks(),
                Categories = _categoryService.GetCategories()
            };
           
            return View(model);
        }
        [HttpGet]
        public IActionResult CreateBook()
        {
           
            ViewBag.Categories = _categoryService.GetCategories();
            return View();
        }

        [HttpPost]
        public IActionResult CreateBook(Book model)
        {
            _bookService.Create(model);
            return RedirectToAction("BookList");
        }
    }
}
