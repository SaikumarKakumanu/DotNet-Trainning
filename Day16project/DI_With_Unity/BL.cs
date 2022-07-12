using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_With_Unity
{
    public class BL
    {

        private IProduct productobj;
        private IOrder orderobj;

        public BL(IProduct ip, IOrder io)
        {
            productobj = ip;
            orderobj = io;
        }
        public void InsertProduct()
        {
            productobj.InsertProduct();
        }
        public void Display()
        {
            orderobj.Display();
        }
    }
}
