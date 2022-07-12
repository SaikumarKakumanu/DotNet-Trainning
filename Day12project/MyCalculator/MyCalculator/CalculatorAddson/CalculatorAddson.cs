using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalculator;

namespace MyCalculator2
{
    public static class CalculatorAddson
    {
        public static int subtract(this Calculator mycalc, int x, int y)
        {
            return x - y;
        }

        public static int product(this Calculator mycalc, int a, int b)
        {
            return a * b;
        }
        
    }
}
