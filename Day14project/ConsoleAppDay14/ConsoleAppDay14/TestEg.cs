using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay14
{
    internal class TestEg
    {

        static void Main()
        {
            int[] arr = { 7, 2, 30 };
            
            IEnumerable<int> square = from x in arr
                                      where (x*x)>20 
                                      select x;
            foreach(int sq in square)
            {
                Console.WriteLine(sq+" - "+sq*sq);
            }

            List<string> stwords = new List<string>();
            stwords.Add("mum");
            stwords.Add("amsterdam");
            stwords.Add("bloom");

            IEnumerable<string> maching = from na in stwords
                                          where na.StartsWith("a") && na.EndsWith("m")
                                          select na;

            foreach(string name in maching)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
