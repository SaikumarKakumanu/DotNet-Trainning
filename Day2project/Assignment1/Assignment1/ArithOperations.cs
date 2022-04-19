using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ArithOperations
    {
        int num1;
        int num2;

        public void operations()
        {
            Console.WriteLine("Enter num1 Value");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Select Operates");
            char operater=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter num2 VAlue");
            num2 = int.Parse(Console.ReadLine());
            switch (operater)
            {
                case '+':
                   int add = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2 + " = " + add);
                    break;

                case '-':
                    int sub = num1 - num2;
                    Console.WriteLine(num1 + " - " + num2 + " = " + sub);
                    break;

                case '*':
                    int multi = num1 * num2;
                    Console.WriteLine(num1 + " * " + num2 + " = " + multi);
                    break;

                case '/':
                    int div = num1 / num2;
                    Console.WriteLine(num1 + " / " + num2 + " = " + div);
                    break;

                    default:
                    Console.WriteLine("Choose Validate Operater");
                    break;

            }
            
        }
    }
}
