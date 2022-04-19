using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1;
            //int num2;
            //Console.WriteLine("Enter num1 Value");
            //num1=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter num2 Value");
            //num2= Convert.ToInt32(Console.ReadLine());
            //if (num1 == num2)
            //    Console.WriteLine(num1 + " and " + num2 + " are equal");
            //else
            //    Console.WriteLine("not equal");
            //PositveOrNegative pn = new PositveOrNegative();
            //pn.checknum();
            ArithOperations ao = new ArithOperations();
            ao.operations();
            Console.ReadLine();
        }
        
    }
}
