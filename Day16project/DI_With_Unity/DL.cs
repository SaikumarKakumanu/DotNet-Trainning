using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_With_Unity
{
    class DL : IProduct
    {
        public string InsertProduct()
        {
            string str = "Dependency injection through unity container";
            Console.WriteLine(str);
            return str;
        }
    }
}
