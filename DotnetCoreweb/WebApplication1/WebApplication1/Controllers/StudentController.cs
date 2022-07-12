using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetStudentLocation()
        {
            return View();
        }

        public IActionResult GetStudentPhoneNo()
        {
            return View();
        }
    }
}
