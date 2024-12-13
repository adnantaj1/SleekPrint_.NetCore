using Microsoft.AspNetCore.Mvc;

namespace SleekPrint.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
