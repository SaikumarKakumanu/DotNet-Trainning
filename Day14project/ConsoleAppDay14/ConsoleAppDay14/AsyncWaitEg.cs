using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppDay14
{
    internal class AsyncWaitEg
    {
        public static void Main()
        {
            FileRead fr = new FileRead();
            Console.WriteLine("file is created.......");
            fr.filereadeoperation();
            Console.Read();
        }
    }

    class FileRead
    {
        public async void filereadeoperation()
        {
            try
            {
                StreamReader sr = File.OpenText(@"C:\DotnetTraining\file1.txt");
                Console.WriteLine($"the first line of the file is: {sr.ReadLine()}");
                sr.Close();
            }
            catch (Exception ex)
            {
                await FileNotFound();
            }
            finally { await ExitProgram(); }
        }
        async Task FileNotFound()
        {
            Console.WriteLine("Specified File not found.. Please check the name and location");
        }

        async Task ExitProgram()
        {
            Console.WriteLine("Enter any key to exit");
        }
    }
}
