using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Project
{
    class LinqOperators
    {
        static void Main()
        {
            string[] fruits = { "Apple", "Mango", "Orange", "Bananas", "Pineapple" };
            string[] arr = { };
            var res = fruits.ElementAt(2);
            Console.WriteLine("the element at index 2 is:{0}",res);

            Console.WriteLine("--------------------------------------------------------------------");

            var r = fruits.ElementAtOrDefault(5);
            Console.WriteLine("the element of index 5 is:{0}", r);
            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine(fruits.First());
            Console.WriteLine(arr.FirstOrDefault());
            Console.WriteLine(fruits.First(a => a.Length == 6));
            Console.WriteLine(fruits.FirstOrDefault(f => f.Length == 6));
            Console.WriteLine(fruits.Last());
            Console.WriteLine(arr.LastOrDefault());

            string[] colors = { "Red" };
            string[] countries = { "India", "Canada", "America", "Australia" };
            var s1 = colors.Single();
            var s2 = arr.SingleOrDefault();
            Console.WriteLine(s1 + "  " + s2);
            try
            {
                var s3 = countries.SingleOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
            Console.Read();
        }
    }
}
