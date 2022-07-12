using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay13
{
    public delegate void MyDelegate(string str);
    internal class EventsEg2
    {

        public event MyDelegate MyEvent;
        public EventsEg2()
        {
            this.MyEvent += new MyDelegate(this.WelcomeUser);
            this.MyEvent+= new MyDelegate(this.DisplayName);
        }

        public void WelcomeUser(string str)
        {
            Console.WriteLine("Welcome "+str);
        }

        public void DisplayName(string str)
        {
            Console.WriteLine(str);
        }

        static void Main()
        {
            EventsEg2 ev2 = new EventsEg2();
            ev2.MyEvent("saikumar");

            Console.Read();
        }
    }
}
