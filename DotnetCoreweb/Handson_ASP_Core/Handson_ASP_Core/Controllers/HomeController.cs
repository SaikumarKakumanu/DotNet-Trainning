using Handson_ASP_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Handson_ASP_Core.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        ILog _log;
        public HomeController(ILog log)
        {
            _log = log;
        }

        public IActionResult Index()
        {
            _log.info("Hello WOrld");
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