using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class OddorEven
    {
        public void oddeven()
        {
            Console.WriteLine("Enter A Value");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("It is even number");
            else
                Console.WriteLine("IT is Odd Number");
        }
     
    }
    
   
}
