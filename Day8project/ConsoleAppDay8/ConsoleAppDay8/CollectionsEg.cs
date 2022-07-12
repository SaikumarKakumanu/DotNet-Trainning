using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay8
{
    internal class CollectionsEg
    {
        static void Main(string[] args)
        {

            //dynamic d;
            //d = 10;
            //d = "abcd";
            //d = 'A';
            //d = 12.00;
            //d = (new Flower("aa", "bb"));
            //Console.WriteLine(d);

            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add("ABCD");
            al.Add(4.5f);
            al.Add('v');
            al.Add(true);
            al.Insert(1, 15);

            ArrayList al2 = new ArrayList();
            al2.Add(2);
            al2.Add(8);
            al2.Add(3);
            al2.Add(10);
            al.InsertRange(1,al2);
            al2.Sort();

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            foreach (var item in al2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The capacity of the arraylist is :{0}", al.Capacity);
            Console.WriteLine("The elements count of the arraylist is :{0}", al.Count);

            // HashTable

            Hashtable ht = new Hashtable();
            ht.Add("101 ", "ht1");
            ht.Add("106 ", "ht2");
            ht.Add("103 ", "ht3");
            ht.Add("201 ", "ht4");
            ht.Add("110 ", "ht5");

            foreach(var s in ht.Keys)
            {
                Console.WriteLine(s);
            }

            foreach (var s in ht.Values)
            {
                Console.WriteLine(s);
            }

            // using Dictionary 
            Console.WriteLine("-----------------------");
            foreach(DictionaryEntry de in ht)
            {
                Console.Write(de.Key);
                Console.Write(de.Value);
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
