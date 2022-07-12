using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay8
{
    delegate void MyFunctionModel();
    delegate int MyDelegate();
    class MultiCastDelegate
    {
        public static void method1()
        {
            Console.WriteLine("Method 1 called");
        }
        public static void method2()
        {
            Console.WriteLine("Method 2 called");
        }
        public static void method3()
        {
            Console.WriteLine("Method 3 called");
        }

        public static int func1()
        {
            return 1;
        }
        public static int func2()
        {
            return 2;
        }

        public static int func3()
        {
            return 3;
        }
        static void Main()
        {

            //the below is creating multiple delegate objects and then multicasting it to an object
            MyFunctionModel d1, d2, d3, d4;
            d1 = new MyFunctionModel(method1);
            d2 = new MyFunctionModel(method2);
            d3 = new MyFunctionModel(method3);
            d4 = d1 + d2 + d3;  // multicasting all delegate objects to a single delegate object
            d4();

            d4 -= d1;
            d4();

            Console.WriteLine("-------------------------");
            //the below is to create only one object and multicast it to point to other functions
            MyFunctionModel m1 = new MyFunctionModel(method1);
            m1 += method2;
            m1 += method3;
            m1();
            Console.WriteLine("-------------------------");

            MyDelegate md = new MyDelegate(func1);
            md += func2;
            md += func3;
            Console.WriteLine(md());

            Console.Read();
        }
    }
}
