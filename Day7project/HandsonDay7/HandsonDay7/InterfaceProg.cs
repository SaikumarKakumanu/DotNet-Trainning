using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonDay7
{
    interface ICustomer1
    {
        void print();
        string msg(string s);
    }

    interface ICustomer2
    {
        void show();
    }

    interface ISuplier: ICustomer2, ICustomer1
    {
        void suplier();
    }

    class Customer : ISuplier
    {
        public void suplier()
        {
            Console.WriteLine("suplier method calling");
        }
        public void show()
        {
            Console.WriteLine("customer2 show method calling");
        }
        public void print()
        {
            Console.WriteLine("customer1 print method calling");
        }
        public string msg(String str)
        {
            return "Hello "+str;
        }
    }
    internal class InterfaceProg
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.print();
            Console.WriteLine(customer.msg("Customer1 interface"));
            customer.show();
            customer.suplier();
            Console.Read();
        }
    }
}
