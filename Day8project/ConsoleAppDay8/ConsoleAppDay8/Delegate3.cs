using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay8
{
    public delegate void prints(string s);

    public class PrintEg
    {
        static FileStream fs;
        static StreamWriter sw;

        public static void WriteToScreen(string str)
        {
            Console.WriteLine("the string is {0}",str);
        }

        public static void WriteToFile(string str)
        {
            fs = new FileStream("message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void sendsData(prints ps)
        {
            ps("This is a class on delegates");
        }
    }
    internal class Delegate3
    {
        static void Main()
        {
            prints ps1 = new prints(PrintEg.WriteToScreen);
            prints ps2 = new prints(PrintEg.WriteToFile);

            ps1("this is write to screen");
            ps2("some data add to file");

            PrintEg.sendsData(ps1);
            PrintEg.sendsData(ps2);

            Console.Read();
        }

    }
}
