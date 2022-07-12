using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay14
{
    class Employee
    {
        public string EmpName { get; } = "Adharsh";
        public double Salary { get; } = 1000.00;

        //various ways to mention properties in a class
        public string Name { get; set; } = "venkat";
        public string Name1 { get; private set; }
        public string CompanyName { get; protected set; } = "Zensar";

        public Employee()
        {
            //EmpName = "Saikumar";
            CompanyName = " New Zensar";
            Console.WriteLine(EmpName+" "+Salary);
        }
    }
    internal class AutoProperityEg : Employee
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.Name = "sai";
            Console.WriteLine(emp.Name1+" "+emp.CompanyName);

            AutoProperityEg ape = new AutoProperityEg();
            ape.CompanyName = "Zensar pvt.ltd.";

            //before c# 6.0 dictionary initializaion
            Dictionary<string, string> empdict = new Dictionary<string, string>()
            { {"Saikumar", "E101"},
              {"venkat", "E102" },
              {"Kumar", "E103" },
               {"sai","E027" }

            };

            //with C# 6.0

            Dictionary<string, string> mydict = new Dictionary<string, string>()
            {
                ["abcd"] = "E123",
                ["efgh"] = "E456",
                ["ijkl"] = null
            };

            Console.WriteLine(@"Dictionary Initializers in C# 6.0
                          List of Employees
                          -----------------------------");

            foreach(KeyValuePair<string, string> kvp in mydict)
            {
                Console.WriteLine($"Name : {kvp.Key}, EmpId : {kvp.Value}" );
            }

            foreach(KeyValuePair<string, string> keyp in empdict)
            {
                Console.WriteLine($"Name : {keyp.Key}, EmpId : {keyp.Value}");
            }

            Console.Read();

        }
    }
}
