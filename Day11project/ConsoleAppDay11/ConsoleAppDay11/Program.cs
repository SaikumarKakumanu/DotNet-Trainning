using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppDay11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread t1 = new Thread(DisplayNumbers); // it invokes the delegate threadstart
            //t1.Start();

            //the above can also be done thru a threadstart object itself

            ThreadStart threadStart = new ThreadStart(DisplayNumbers);
            //Thread t1=new Thread(threadStart);
            //t1.Start();
            threadStart();

            Console.Read();

        }
        static void DisplayNumbers()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method "+i);
            }
        }
    }
}
