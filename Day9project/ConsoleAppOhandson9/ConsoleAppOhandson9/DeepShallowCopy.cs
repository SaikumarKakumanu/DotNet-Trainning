using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOhandson9
{

    class Person
    {
        public int age;
        public PersonDescription desc;

        public Person(int a, string fn, string ln)
        {
            age = a;
            desc = new PersonDescription(fn, ln);
        }

        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person dcopy = new Person(this.age, desc.Fname, desc.Lname);
            return dcopy;
        }
    }

    public class PersonDescription
    {
        public string Fname;
        public string Lname;

        public PersonDescription(string f, string l)
        {
            Fname = f;
            Lname = l;
        }
    }

    internal class DeepShallowCopy
    {

        static void Main()
        {
            // Shallow copy

            Person p1 = new Person(22, "sai", "kumar");
            Person p2 = (Person)p1.ShallowCopy();
            Console.WriteLine(p1.age+" "+p1.desc.Fname+" "+p1.desc.Lname);
            p2.desc.Fname = "kakumanu";
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"the p1 of fnmae is {p1.desc.Fname}");
            Console.WriteLine($"the p2 of fnmae is {p2.desc.Fname}");
            Console.WriteLine("------------------------------");
            Console.WriteLine(p1.age + " " + p1.desc.Fname + " " + p1.desc.Lname);
            Console.WriteLine(p2.age +" "+p2.desc.Fname+" "+p2.desc.Lname);

            // deep copy

            Person p3 =p1.DeepCopy();
            Console.WriteLine($"p3 data  is :{p3.age}, {p3.desc.Lname},{p3.desc.Fname}");
            Console.WriteLine($"p1 data is : {p1.age}, {p1.desc.Lname},{p1.desc.Fname}");
            p3.desc.Fname = "sai";
            Console.WriteLine("--------------");
            Console.WriteLine($"p3 data  is :{p3.age}, {p3.desc.Fname}, {p3.desc.Lname}");
            Console.WriteLine($"p1 data is : {p1.age}, {p1.desc.Fname}, {p1.desc.Lname}");
            Console.WriteLine("-------------");
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p3.GetHashCode());

            //if we equate 2 objects then
            p2 = p1;
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());

            Console.Read();
        }
    }
}
