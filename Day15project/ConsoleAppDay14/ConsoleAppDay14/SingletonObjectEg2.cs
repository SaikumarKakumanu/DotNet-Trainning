using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay14
{
    public sealed class SingletonObjectEg2
    {
        private static int count = 0;
        private static SingletonObjectEg2 _single = null;

        //returning the only one object thru a property

        public static SingletonObjectEg2 GetInstance
        {
            get
            {
                if (_single == null)
                {
                    _single = new SingletonObjectEg2();
                    
                }
                return _single;
            }
        }

        private SingletonObjectEg2()
        {
            count++;
            Console.WriteLine("Count value is : "+count.ToString());
        }

        public void showdetails(string s)
        {
            Console.WriteLine(s);
        }
    }
}
