using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           Accounts accounts = new Accounts();
           
            accounts.credit(4000.00f);
            //accounts.debit(3000.00f);
            accounts.showdetails();
            // Product product = new Product();
            //product.diplayproductdetails();

            ArraysEg ae = new ArraysEg();
            ae.TwoDimension();
            ae.JaggedArray();
            
            Console.ReadLine();
        }
    }
}
