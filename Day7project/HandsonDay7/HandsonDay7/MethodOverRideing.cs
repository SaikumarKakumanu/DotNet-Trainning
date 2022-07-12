using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonDay7
{

    class Shape
    {
        protected float R,L,B;

        //this function is calculating the area of circle. It is marked virtual to allow
        //overriding in the derived class
        public virtual float Area()
        {
            return 3.14f;
        }
    }

    class Rectangle : Shape
    {
        public void getLB()
        {
            Console.WriteLine("Enter Length of Rec : ");
            L=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth of Rec : ");
            B=float.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            getLB();
            return L * B;
        }
    }

    class Circle : Shape
    {
        public void getRadius()
        {
            Console.WriteLine("Enter Radius of circle : ");
            R=float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
           getRadius();
            return 3.14f*R*R;
        }
    }
    internal class MethodOverRideing
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            //r.Area();
            Console.WriteLine("The rectangle area is : "+r.Area());

            Circle c = new Circle();
           // c.Area();
            Console.WriteLine("The circle Area is : "+c.Area());
            Console.Read();
        }
    }
}
