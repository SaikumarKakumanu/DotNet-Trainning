using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonDay6
{
    class Empolyee
    {
        int Empid, Empage;
        string Name, Address;
        static string companyname;

        // Both public and private constructors
        private Empolyee()
        {
            Console.WriteLine("Enter the Empid, Empage, Name, Address");
            this.Empid =Convert.ToInt32(Console.ReadLine());
            this.Empage =Convert.ToInt32(Console.ReadLine());
            this.Name =Console.ReadLine();
            this.Address =Console.ReadLine();  
        }

        public Empolyee(int empid, string name)
        {
            Empid = empid;
            Name = name;
        }

        // copy constructor
        public Empolyee(Empolyee emp)
        {
            this.Empid= emp.Empid;
            this.Empage = emp.Empage;
            this.Name = emp.Name;
            this.Address = emp.Address;
            companyname = "My New Zensar";
        }

        static Empolyee()
        {
            companyname = "Zensar";
        }

        public void display()
        {
            Empolyee empolyee = new Empolyee();
            Console.WriteLine($"Empid is {Empid}, Empage is {Empage}, Emp Name is {Name}, Emp address is {Address}, Emp company name is {companyname}");
            companyname = " newZensar";
            Console.WriteLine($"Empid is {Empid}, Empage is {Empage}, Emp Name is {Name}, Emp address is {Address}, Emp company name is {companyname}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Empolyee empolyee1 = new Empolyee(1199,"CDEF");
            empolyee1.display();
            Empolyee empolyee2 = new Empolyee(empolyee1);
            empolyee2.display();
            Console.Read();
        }
    }
}
