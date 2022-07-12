using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonDay4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter arrays value of 10");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            ReverseArray rv = new ReverseArray();
            rv.reversearray();
            CopyArray ca = new CopyArray();
            ca.ArrayToArray();
            Console.ReadLine();
        }
    }
}
