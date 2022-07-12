using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Project
{
    class Aggregates
    {
        static void Main()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Average of the Numbers is : {0}",numbers.Average());
            Console.WriteLine("The sum of the Numbers is : {0}",numbers.Sum());
            Console.WriteLine("The maximum Number is : {0}",numbers.Max());
            Console.WriteLine("Count of Elements : {0}",numbers.Count());

            //Aggregate : preforms a specified operation to each element in a collection,
            //while carrying the result forward

            var result = numbers.Aggregate((a,b)=> a + b);
            Console.WriteLine("Aggregated value after Addition : {0}",result);

            result=numbers.Aggregate((a,b)=> a * b);
            Console.WriteLine("Aggregate result after multiplication :{0}",result);

            //Aggregate : preforms a specified operation to each element in a collection,
            //while carrying the result forward. Seed sets initial value

            result = numbers.Aggregate(10, (a,b)=> a + b);
            Console.WriteLine($"{result} is seed with value of 10 ");

            result=numbers.Aggregate(10, (a,b)=> a*b);
            Console.WriteLine($"{result} is seed with value of 10");

            //conversion of collection to list

            string[] names = { "pamela", "Ben", "Jhon"};
            List<string> lname = names.ToList();
            
            Console.WriteLine(string.Format("names is of type :{0}",names.GetType().Name));
            Console.WriteLine(string.Format("lname is of type :{0}", lname.GetType().Name));

            Console.ReadLine();
        }
    }
}
