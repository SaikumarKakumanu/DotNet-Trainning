using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalculator; //dll
using MyCalculator2;

namespace CalculatorClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculatorobj = new Calculator();
            Console.WriteLine(calculatorobj.add(5,6));
            Console.WriteLine(calculatorobj.Message("saikumar"));
            Console.WriteLine(calculatorobj.subtract(6, 2));
            Console.WriteLine(calculatorobj.product(3,7));

            Console.Read();
        }
    }
}
