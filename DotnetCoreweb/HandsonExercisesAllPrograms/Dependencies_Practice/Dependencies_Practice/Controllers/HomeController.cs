using Dependencies_Practice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dependencies_Practice.Controllers
{
    public class HomeController : Controller
    {
      //  private readonly ILogger<HomeController> _logger;

      ILog _log;

        public HomeController(ILog log)
        {
            _log = log;
        }

        public IActionResult Index()
        {
            _log.info("Execute /Home/Index");
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