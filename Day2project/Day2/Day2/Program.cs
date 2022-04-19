using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Hi! " + name + " Welcome to the world of C#");
            OddorEven oe = new OddorEven();
            oe.oddeven();
            LargeSmall ls = new LargeSmall();
            ls.largesmall();
            Console.Read();
        }
    }
}
