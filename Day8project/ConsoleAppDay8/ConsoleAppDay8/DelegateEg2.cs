using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay8
{
    delegate int NumChange(int a);

    internal class DelegateEg2
    {
        static int num = 10;
        public static int Addnum(int p)
        {
            num += p;
            return num;
        }
        public static int multiplynum(int q)
        {
            num *= q;
            return num;
        }

        public static int getnum()
        {
            return num;
        }

        static void Main()
        {
            NumChange nc1 = new NumChange(Addnum);
            NumChange nc2 = new NumChange(multiplynum);

            Console.WriteLine("Value of Num before delegate call : {0}", getnum());
            nc1(20);
            Console.WriteLine("Value of Num After delegate nc1 call : {0}", getnum());
            nc2(10);
            Console.WriteLine("Value of Num After delegate nc2 call : {0}", getnum());

            Console.Read();
        }
    }
}
