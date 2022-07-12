using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay11
{
    internal class HandsOnDay11
    {

        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public static List<Employee> GetEmployees()
            {
                List<Employee> employees = new List<Employee>();
                Employee e1 = new Employee { Id = 5436, Name = "Anusha" };
                Employee e2 = new Employee { Id = 4563, Name = "Akash" };
                Employee e3 = new Employee { Id = 5647, Name = "saikumar" };
                Employee e4 = new Employee { Id = 7645, Name = "Venkat" };
                employees.Add(e1);
                employees.Add(e2);
                employees.Add(e3);
                employees.Add(e4);
                return employees;
            }
        }
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            // numbers divisible by 3
            var divi = from m in arr
                       where (m % 3 )==0
                       select m;

            // max  and min numbers in given array 

            var max = arr.Max();
            var min = arr.Min();
            Console.WriteLine(max);
            Console.WriteLine(min);

            Console.WriteLine("--------------------------");
            foreach( var val in divi)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("---------------------------");

            var EmpNames = from emp in Employee.GetEmployees()
                                           where emp.Name.EndsWith("a")
                                           select emp.Name;

            foreach (var e in EmpNames)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
