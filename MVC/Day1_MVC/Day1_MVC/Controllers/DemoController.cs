using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day1_MVC.Models;

namespace Day1_MVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        // Action method 1.
        public string NormalMethod()
        {
            return "Hello All...";
        }

        // Action method 2.
        public ContentResult contents()
        {
            return Content("Good morning to all...");
        }

        //action method 3.
        [NonAction]
        public EmptyResult NoResult()
        {
            int amt = 4500;
            float SI = (amt * 3 * 2) / 100;
            return new EmptyResult();
        }

        //action method 4.
        public JsonResult EmployeeData()
        {
            Employee e = new Employee();
            e.Id = 101;
            e.Name = "Saikumar";
            e.Age = 22;
            return Json(e,JsonRequestBehavior.AllowGet);
        }

        //action method with redirectresult
        //here we are redirecting to an action method of the same controller

        public RedirectResult RedirectMethod()
        {
            return Redirect("EmployeeData");
        }

        //action method redirecting to an action method of another controller
        public RedirectResult Redirect_to_controller()
        {
            return Redirect("/Home/About");
        }
    }
}