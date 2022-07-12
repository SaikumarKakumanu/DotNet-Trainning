using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonDay7
{

    class Distance
    {
        int dist;

        public int _Dist
        {
            get { return dist; }
            set { dist = value; }
        }

        // overload the + operator

        public static Distance operator +(Distance d1, Distance d2)
        {
            Distance temp = new Distance();
            temp.dist=d1._Dist+d2._Dist;
            return temp;
        }
    }
    internal class OperaterOverload
    {
        static void Main(string[] args)
        {
            Distance d1= new Distance();
            Distance d2= new Distance();
            d1._Dist = 30;
            d2._Dist = 50;
            Distance d3= d1 + d2;
            Console.WriteLine("the total distance is : "+d3._Dist);
            Console.Read();

        }
    }
}
