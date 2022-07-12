using Microsoft.AspNetCore.Mvc;

namespace ViewBag_Practice.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetFirstName()
        {
            ViewBag.FirstName = "Saikumar";
            return View();
        }
        public IActionResult GetLastName()
        {
            ViewBag.LastName = "Kakumanu";
            return View();
        }
        public IActionResult GetLocation()
        {
            ViewBag.Location = "Hyderabad";
            return View();
        }
    }
}
