using Microsoft.AspNetCore.Mvc;

namespace BooksForAll.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
