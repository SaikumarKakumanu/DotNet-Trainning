using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2MVC_EF.Models;

namespace Day2MVC_EF.Controllers
{
    public class MultipleTableController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: MultipleTable
        public ActionResult Index()
        {
            return View();
        }
        //to view data from multiple tables using navigation properties
        public ActionResult Cust_order_Details()
        {
            return View(db.Orders.ToList());
        }
    }
}