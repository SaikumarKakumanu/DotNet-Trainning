using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay12
{
    delegate void Print(int val);
    delegate void ArithmeticHandler(int fnum, int snum);
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Print p = delegate (int x) { Console.WriteLine("inside Anonymous function:{0}",x); };
            p(10);

            //anonymous method can access the variable defined in an outer function
            Print p1 = delegate (int x) { x += i; Console.WriteLine("Anonymous method accessing outside variable: {0}", x); };
            p1(20);

            //using method expression to call anonymous 

            int[] arr= {1,2,3,4,5,6,7,8,9,10};
            int[] evennos = Array.FindAll(arr,delegate (int num) { return num % 2== 0; });
            Console.Write("the even nos is :");

            foreach(int z in evennos)
            {
                Console.Write(z+" ");
            }
            Console.WriteLine();
            //using method expression to call anonymous 
            ArithmeticHandler ah = delegate (int fnum, int snum)
            {
                Console.WriteLine("Addition of {0} and {1} is {2}", fnum, snum, fnum + snum);
            };
            ah(10, 20);

            // with lambda

            ArithmeticHandler ah1 = (int fnum, int snum) =>
            {
                Console.WriteLine("Addition of {0} and {1} is {2}", fnum, snum, fnum + snum);
            };
            ah1(20,30);
            Console.Read();
        }
    }
}
