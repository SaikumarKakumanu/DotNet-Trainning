using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3MVC_CodeFirst.Models;
namespace Day3MVC_CodeFirst.Content
{
    public class CarController : Controller
    {
        CarContext cc = new CarContext();
        // GET: Car
        public ActionResult Index()
        {

            return View(cc.Cars.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Car c)
        {
            cc.Cars.Add(c);
            cc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Car c = cc.Cars.Find(id);
            return View(c);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Car c = cc.Cars.Find(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Edit(Car car)
        {
            Car cr = cc.Cars.Find(car.CarNo);
            cr.CarName = car.CarName;
            cr.CarType = car.CarType;
            cr.CarCost = car.CarCost;
            cc.SaveChanges();
            return RedirectToAction("Index");

        }

       // [HttpGet]
        public ActionResult Delete(int id)
        {
            Car c = cc.Cars.Find(id);
            return View(c);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConform(int id)
        {
            Car c = cc.Cars.Find(id);
            cc.Cars.Remove(c);
            cc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}