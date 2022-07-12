﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            addAsync();
            Console.Read();
        }

        async static Task addAsync()
        {
            try
            {
                int[] arr =new int[5];
                arr[10] = 20;
            }
            catch (Exception ex)
            {
                await ExceptionOccured();
            }
            finally
            {
                await ReleasingResources();
            }
        }

        async static Task ExceptionOccured()
        {
            Console.WriteLine("array index Exception Occured");
        }
        async static Task ReleasingResources()
        {
            Console.WriteLine("Resources have been released.........");
        }

    }
}
