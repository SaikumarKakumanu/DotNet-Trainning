using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class LargeSmall
    {
        int num1;
        int num2;
        int num3;
        public void largesmall()
        {
            Console.WriteLine("Enter Num1 Value");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Num2 Value");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Num3 Value ");
            num3= int.Parse(Console.ReadLine());
            if (num1 > num2)
                Console.WriteLine("Num1 is Largest");
            else if (num2 > num3)
                Console.WriteLine("num2 is largest");
            else if (num1 < num3)
                Console.WriteLine("num1 is smallest");
            else
                Console.WriteLine("enter vaild values");
        }
    }
}
