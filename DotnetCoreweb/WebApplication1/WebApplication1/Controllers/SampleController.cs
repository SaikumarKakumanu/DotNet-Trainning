using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
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
            ViewBag.Location = "India";
            return View();
        }
    }
}
