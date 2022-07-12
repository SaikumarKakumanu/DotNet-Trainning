using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonDay7
{
    internal class MethodOverloading
    {

        public static void Swap(int a, int b)
        {
            Console.WriteLine("before swapping a = "+a+" b = "+b);
            a=a+b;
            b=a-b;
            a=a-b;
            Console.WriteLine("Swapping integers a = "+a+" b = "+b);
        }

        public static void Swap(char a1, char a2)
        {
            Console.WriteLine("Before swapping values of char a1 and a2 : " + a1 + " " + a2);
            char temp;
            temp = a1;
            a1=a2;
            a2 = temp;
            Console.WriteLine("After swapping values of char a1 and a2 : " + a1 + " " + a2);
        }
        static void Main(string[] args)
        {
            MethodOverloading.Swap(10,20);
            MethodOverloading.Swap('b', 'c');
            Console.Read();
        }
    }
}
