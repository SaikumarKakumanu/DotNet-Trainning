using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay14
{

    public class SingleTonObject
    {
        //create static object of the class and creating it through a private constructor
        private static SingleTonObject sobj = new SingleTonObject();

        //Private Constructor
        private SingleTonObject() { }

        //Method to retrieve the one and only object of the class
        public static SingleTonObject GetObject()
        {
            return sobj;
        }

        public void DisplayObject()
        {
            Console.WriteLine("Hi.. This is SingleTon Object");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Geting a singleton class object through the method of the class and not the constructor

            SingleTonObject sobj = SingleTonObject.GetObject();
            sobj.DisplayObject();

            SingletonObjectEg2 sobj2 = SingletonObjectEg2.GetInstance;
            sobj2.showdetails("client 1");

            SingletonObjectEg2 s3 = SingletonObjectEg2.GetInstance;
            s3.showdetails("client 2");
            Console.ReadLine();
        }
    }
}
