using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SleekPrint.Areas.Customer.Controllers
{
    public class ContactController : Controller
    {
        [Area("Customer")]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
