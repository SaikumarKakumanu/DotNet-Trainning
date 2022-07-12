using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonDay4
{
    internal class ReverseArray
    {
        public void reversearray()
        {
            int [] arr=new int[3];
            arr[0]=2;
            arr[1]=5;
            arr[2]=7;
            Console.WriteLine("Before rverseing array");
            for (int i=0;i<arr.Length;i++)
            {
               
                Console.WriteLine(arr[i]);
            }
            
            int n=arr.Length;
            Console.WriteLine("After reversing array");
            for (int i = n-1; i >= 0; i--)
            {
                
                Console.WriteLine(arr[i]);
            }
            
        }
    }
}
