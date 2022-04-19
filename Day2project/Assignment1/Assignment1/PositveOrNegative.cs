using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class PositveOrNegative
    {
        int num1;
       

        public void checknum()
        {
            Console.WriteLine("Enter num1 value");
            num1 = Convert.ToInt32(Console.ReadLine());
           
            if (num1 > 0)
            {
                Console.WriteLine(num1 + " is a positive number");
            }
            else
                Console.WriteLine(num1 + " is Negitive number");
        }
    }
}
