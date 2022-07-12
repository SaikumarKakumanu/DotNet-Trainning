using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay11
{
    internal class DisposableEg:IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Releasing all Resources..");
        }

        public void DoSomething()
        {
            Console.WriteLine("Using Various Resources..");
        }

        public DisposableEg()
        {
            Console.WriteLine("Allocating various Resources...");
        }
        static void Main()
        {
            //Eg1

            //string muiltilines = @"This is line 1.
            // this is line 2
            // this is line 3
            // line 4
            // finall line 5th line";
            //using (var reader = new StringReader(muiltilines))
            //{
            //    string iteam;
            //    do
            //    {
            //        iteam = reader.ReadLine();
            //        Console.WriteLine(iteam);
            //    }while (iteam != null);
            //}

            //Eg2

            //using(var sreader = new StreamReader(@"C:\DotnetTraining\file1.txt"))
            //{
            //    Console.WriteLine(sreader.ReadToEnd());
            //}

            //eg 3 using try finally which is equivalent to using block with some coding

            //var streader = new StreamReader(@"C:\DotnetTraining\file1.txt");
            //try
            //{
            //    Console.WriteLine(streader.ReadToEnd());
            //}
            //finally
            //{
            //    if (streader != null)
            //        streader.Dispose();
            //}


            //Eg4 using IDisposal Interface
            using (var dispeg = new DisposableEg())
            {
                dispeg.DoSomething();
            }


            Console.Read();
        }
    }
}
