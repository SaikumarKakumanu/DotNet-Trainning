using Day2_ASP_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Day2_ASP_Core.Controllers
{
    public class HomeController : Controller
    {
        ILog _log;

        public HomeController(ILog log) //new MyConsoleLogger()
        {
            _log = log;
        }

        public IActionResult Index()
        {
            _log.info("Executing /home/index");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}