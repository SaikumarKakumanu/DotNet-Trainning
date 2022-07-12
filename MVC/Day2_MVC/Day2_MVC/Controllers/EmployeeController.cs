using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2_MVC.Models;

namespace Day2_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee e = new Employee()
            {
                Id = 101,
                Name = "Saikumar",
                DOJ = DateTime.Now,
                Email = "saikumar@gmail.com"
            };
            return View(e);
        }
    }
}