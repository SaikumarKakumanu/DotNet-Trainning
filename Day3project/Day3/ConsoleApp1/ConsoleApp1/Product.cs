using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        static int productid;
        static string productname;
        static int quantity;

        public Product()
        {
            productid = 1;
            productname = "Apples";
            quantity = 10;
            Console.WriteLine("productname is "+productname+" product id is "+productid+" product quantity is "+quantity);
        }
        ~Product()
        {
            Console.WriteLine("Return product");
            Console.ReadLine();
        }
        static void productdetails()
        {
            Console.WriteLine(" from static method");
            Console.WriteLine("productname is " + productname + " product id is " + productid + " product quantity is " + quantity);
        }
        public void diplayproductdetails()
        {
            Console.WriteLine("from pubilc method");
            Console.WriteLine("productname is " + productname + " product id is " + productid + " product quantity is " + quantity);
            productdetails();
        }
    }
}
