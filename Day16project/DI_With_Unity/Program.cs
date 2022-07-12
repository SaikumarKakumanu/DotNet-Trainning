using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace DI_With_Unity
{
    class Program
    {
        static void Main(string[] args)
        {

            UnityContainer uc = new UnityContainer();
            uc.RegisterType<BL>();
            uc.RegisterType<DL>();

            uc.RegisterType<IProduct, DL>();
            uc.RegisterType<IOrder, MyOrder>();

            BL bl = uc.Resolve<BL>();
            bl.InsertProduct();
            bl.Display();
            Console.ReadLine();
        }
    }
}
