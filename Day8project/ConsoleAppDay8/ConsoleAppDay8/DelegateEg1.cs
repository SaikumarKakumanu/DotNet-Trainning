using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay8
{
    public delegate void MyDelegates(string s);
    delegate void Secdelegate();
    class DelegateEg1
    {
        public void accept(string s)
        {
            Console.WriteLine("Hello " + s);
        }

        public  static void show(string s)
        {
            Console.WriteLine(s);
        }

        public void Noperameter()
        {
            Console.WriteLine("no parameter");
        }
        public string msg()
        {
            return "hello";
        }


        static void Main(string[] args)
        {
            DelegateEg1 del1=new DelegateEg1();
            Console.WriteLine(del1.msg());

            MyDelegates md1 = new MyDelegates(show);
            MyDelegates md2 = new MyDelegates(del1.accept);

            Secdelegate scd = new Secdelegate(del1.Noperameter);

            md1("saikumar");
            md2("abcd");

            scd();
            Console.Read();
        }
    }
}
