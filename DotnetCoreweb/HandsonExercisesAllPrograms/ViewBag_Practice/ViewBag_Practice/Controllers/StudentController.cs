using Microsoft.AspNetCore.Mvc;

namespace ViewBag_Practice.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetFirstName()
        {
            return View();
        }
        public IActionResult GetLastName()
        {
            return View();
        }
        public IActionResult GetLocation()
        {
            return View();
        }
    }
}
