using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Project
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

       public static List<Student> GetStudents()
        {
            List<Student> studentlist = new List<Student>()
            {
                new Student() { ID = 1, Name = "Jagadeesh", Age = 13 },
                new Student() { ID = 2, Name = "Monika", Age = 21 },
                new Student() { ID = 3, Name = "Brijesh", Age = 18 },
                new Student() { ID = 4, Name = "Ram", Age = 20 },
                new Student() { ID = 5, Name = "Roma", Age = 15 }
            };
            return studentlist;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 99, 45, 53, 24, 14, 59 };

            var result = from n in numbers
                         where n>50
                         orderby n
                         select n.ToString();
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

            IEnumerable<string> snamelist = from stlist in Student.GetStudents()
                                            where stlist.Age>=20
                                            select stlist.Name;

            IEnumerable<string> stnmae = from std in Student.GetStudents()
                                         where std.Name.EndsWith("h")
                                         select std.Name;

            var slist = from std in Student.GetStudents()
                        where std.ID == 3
                        select std;

            List<Student> studentlist = Student.GetStudents();
            var teenAgeStudents = studentlist.Where(s=> s.Age>12 && s.Age<20).ToList<Student>();

            foreach(string sname in snamelist)
            {
                Console.WriteLine(sname);
            }
            Console.WriteLine("--------------------------------------------------------------");

            foreach(string stdname in stnmae)
            {
                Console.WriteLine(stdname);
            }
            Console.WriteLine("--------------------------------------------------------------");

            foreach (var v in slist)
            {
                Console.WriteLine(v.ID+" "+v.Name+" "+v.Age);
            }
            Console.WriteLine("--------------------------------------------------------------");

            foreach (var v in teenAgeStudents)
            {
                Console.WriteLine(v.ID + " " + v.Name + " " + v.Age);
            }
            Console.ReadLine();
        }
    }
}
