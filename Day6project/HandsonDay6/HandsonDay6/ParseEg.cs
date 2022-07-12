using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonDay6
{
    internal class ParseEg
    {
       static void Main(string[] args)
        {
            int i = 10;
            float f = 123.45f;
            i= (int)f; //explicit typecast and hence there is data loss
            Console.WriteLine(i);
            // i = int.Parse(f); //cannot pass variables to parse function as it expects only string
            i=Convert.ToInt32(f); // conversion function
            Console.WriteLine("conversion : "+i);

            string str = "100Apples";
            //i=int.Parse(str);  //the above will throw an exception while trying to parse, since
            //the value is a proper string
            string str1 = "100";
            i=Convert.ToInt32(str1);
            Console.WriteLine(i);

            //to avoid exception we can use a tryParse()
            int res = 0;
            bool status = int.TryParse(str, out res);
            if (status)
            {
                Console.WriteLine("Sucessfully "+res);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.Read();
        }
    }
}
