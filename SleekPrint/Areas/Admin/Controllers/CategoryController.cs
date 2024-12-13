using Microsoft.AspNetCore.Mvc;
using SleekPrint.DataAccess.Data;
using SleekPrint.DataAccess.Repository.IRepository;
using SleekPrint.Models;
namespace SleekPrint.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Category> categoryList = _unitOfWork.Category.GetAll().ToList();
            return View(categoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            _unitOfWork.Category.Add(obj);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }

    }
}
