using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day1_MVC.Models;

namespace Day1_MVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> prolist = new List<Product>();
            prolist.Add(new Product { Id = 101, Name = "Mobile", price = 15000.00f });
            prolist.Add(new Product { Id = 102, Name = "Charger", price = 150.00f });
            prolist.Add(new Product { Id = 103, Name = "Laptop", price = 19999.99f });
            prolist.Add(new Product { Id = 104, Name = "Pendrive", price = 1000.00f });

            return View("DisplayProducts", prolist);
        }

        public ActionResult DisplayProducts(List<Product> productslist)
        {
            return View(productslist);
        }

        public ActionResult DisplaySingleProduct()
        {
            Product pr = new Product()
            {
                Id = 100,
                Name = "Tablet",
                price = 12000.00f
            };
            return View(pr);
        }
    }
}