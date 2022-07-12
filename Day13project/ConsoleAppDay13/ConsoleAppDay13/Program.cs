using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay13
{
    class EventClass
    {
        private int value;
        //user -> Event -> Delegate -> Functions()

        public delegate void numbermanipulator();
        public event numbermanipulator changenum;

        public virtual void onNumChange()
        {
            Console.WriteLine("Event raised....");
        }

        public EventClass(int n)
        {
            this.changenum = new numbermanipulator(this.onNumChange);
            setValue(n);
        }

        public void setValue(int x)
        {
            if(value != x)
            {
                value = x;
                changenum();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EventClass ec = new EventClass(10);
            ec.setValue(10);
            ec.setValue(15);
            ec.setValue(20);
            Console.Read();
        }
    }
}
