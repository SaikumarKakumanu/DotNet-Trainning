﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1_MVC.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            List<string> flowerlist = TempData["flowers"] as List<string>;

            return RedirectToAction("TestAction");
        }

        public ActionResult TestAction()
        {
            List<string> teststr = TempData["flowers"] as List<string>;
            return View(teststr);
        }

        public ActionResult JobRules1()
        {
            List<string> rules = new List<string>()
            {
                "Avoid T-Shirts", "Carry ID Card", "Be on Time","Work Committedly"
            };

            ViewBag.GetRules = rules as List<string>;
            return View();
        }

        public ActionResult JobRules2()
        {
            List<string> rules = new List<string>()
            {
                "Avoid T-Shirts", "Carry ID Card", "Be on Time","Work Committedly"
            };

            //2. using ViewData to transfer data from controller to view
            ViewData["Followrules"] = rules as List<string>;
            return View();
        }

        //3. To check if data can be transfered across requests
        public ActionResult Test_DataTransfer()
        {
            ViewBag.data1 = "Data1";
            ViewData["data2"] = "Data 2";
            return View(); // data1 and data2 data can be transferred to the view

            // return Redirect("Index");
        }

        //4. maintaining state of the page/view and transferring data to other views
        //either within the same controller or other controllers
        //using TempData
        public ActionResult FirstRequest()
        {
            List<string> strlist = new List<string>();
            strlist.Add("Roses");
            strlist.Add("Jasmines");
            strlist.Add("Lilies");
            strlist.Add("Mogra");

            TempData["flowers"] = strlist;
            TempData.Keep();
            return View();
        }

        public ActionResult SecondRequest()
        {
            //if(TempData["flowers"]==null)
            List<string> flwlist = TempData["flowers"] as List<string>;
            TempData.Keep();
            //  return View(flwlist);
            return RedirectToAction("Index");
        }
    }
}