using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay14
{
    internal class HandsonEg
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("E002", "Manoj B");
            ht.Add("E007", "Revathi");
            ht.Add("E010", null);
            ht.Add(null, "E011");

            foreach (DictionaryEntry de in ht)
            {
                Console.Write(de.Key);
                Console.Write(de.Value);
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
