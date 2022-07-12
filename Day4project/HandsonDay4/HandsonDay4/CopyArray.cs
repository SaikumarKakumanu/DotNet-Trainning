using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonDay4
{
    internal class CopyArray
    {
        public void ArrayToArray()
        {
            int [] array1=new int[3];
            array1[0]=15;
            array1[1]=10;
            array1[2]=12;
            int [] array2=new int[array1.Length];
            for(int i=0; i<array1.Length; i++)
            {
                array2[i]=array1[i];
            }
            Console.WriteLine("Elements in first array");
            for(int i=0;i<array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine("Elements in second array");
            for(int i=0;i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
        }
    }
}
