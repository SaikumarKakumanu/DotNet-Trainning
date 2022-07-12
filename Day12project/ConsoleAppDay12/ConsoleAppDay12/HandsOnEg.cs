using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay12
{
    internal class HandsOnEg
    {
        static void Main()
        {
            // delegate Action Anonymous function
            Action<string> action = delegate (string message)
            {
                Console.WriteLine(message.ToUpper());
            };
            action("batch");

            // with lambda expression
            Console.WriteLine("-------------------------------------------");
            Action<string> action1 = s => Console.WriteLine(s.ToUpper());
            action1("batch");

            // predelegate char with lambda expression
            Console.WriteLine("---------------------------------------------");
            Predicate<char> p1 = c => { return char.IsDigit(c); };
            Console.WriteLine("Char.IsDigit() returned : " + p1('5'));
           

            //4.Predicate delegate with anonymous method 
            Predicate<char> chardel = delegate (char c) { return char.IsDigit(c); };
            Console.WriteLine($"Char.IsDigit() returned : {chardel('A')}");

            Console.Read();
        }
    }
}
