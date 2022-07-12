using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LINQ_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string[] Names = { "Anil", "Sharma", "Abdullah", "Imran", "Siva", "Naresh", "Suresh", "Suman" };
            //    UsingLinq(Names);
            //    Console.WriteLine("----------------------");
            //    UsingLinqExtensions(Names);
            //    Console.WriteLine("----------------------");
            //    UsingLinqFunctions(Names);
            //    Console.WriteLine("----------------------");
            //    UsingLinqAnonymousMethods(Names);
            //    Console.ReadLine();
            //LINQReadXML();
            //LINQtoXmlAddNode();
            LINQtoXmlDeleteNode();
        }

        //private static void UsingLinq(string[] names)
        //{
        //    IEnumerable<string> query = from s in names
        //                                where s.Length == 5
        //                                orderby s
        //                                select s.ToUpper();

        //    foreach(var item in query)
        //        Console.WriteLine(item);
        //}

        //private static void UsingLinqExtensions(string[] names)
        //{
        //    IEnumerable<string> query = names
        //                                .Where(x => x.Length == 5)
        //                                .OrderBy(x => x)
        //                                .Select(x => x.ToUpper());

        //    foreach(var item in query)
        //        Console.WriteLine(item);
        //}

        //private static void UsingLinqFunctions(string[] names)
        //{
        //    Func<string, bool> filter = x => x.Length == 5;
        //    Func<string, string> extract = x => x;
        //    Func<string, string> project = x => x.ToUpper();

        //    IEnumerable<string> query = names.Where(filter).OrderBy(extract).Select(project);

        //    foreach(var item in query)
        //        Console.WriteLine(item);
        //}

        //private static void UsingLinqAnonymousMethods(string[] names)
        //{
        //    Func<string, bool> filter = delegate (string s)
        //    {
        //        return s.Length == 5;
        //    };

        //    Func<string, string> extract = delegate (string s)
        //    {
        //        return s;
        //    };

        //    Func<string, string> project = delegate (string s)
        //    {
        //        return s.ToUpper();
        //    };

        //    IEnumerable<string> query = names.Where(filter).OrderBy(extract).Select(project);

        //    foreach(var item in query)
        //        Console.WriteLine(item);
        //}

        //private static void LINQReadXML()
        //{
        //    string myXML = @"<Departments>
        //               <Department>Account</Department>
        //               <Department>Sales</Department>
        //               <Department>Pre-Sales</Department>
        //               <Department>Marketing</Department>
        //               </Departments>";

        //    XDocument xdoc = new XDocument();
        //    xdoc = XDocument.Parse(myXML);

        //    var result = xdoc.Element("Departments").Descendants();
        //    foreach(XElement item in result)
        //    {
        //        Console.WriteLine("Department Name - "+item.Value);
        //    }
        //    Console.WriteLine("\n Press any key to continue.");
        //    Console.ReadKey();
        //}

        //private static void LINQtoXmlAddNode()
        //{
        //    string myXML = @"<Departments>
        //               <Department>Account</Department>
        //               <Department>Sales</Department>
        //               <Department>Pre-Sales</Department>
        //               <Department>Marketing</Department>
        //               </Departments>";

        //    XDocument xdoc = new XDocument();
        //    xdoc = XDocument.Parse(myXML);

        //    xdoc.Element("Departments").Add(new XElement("Department", "Finance"));
        //    xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));

        //    var result = xdoc.Element("Departments").Descendants();
        //    foreach (XElement item in result)
        //    {
        //        Console.WriteLine("Department Name - " + item.Value);
        //    }
        //    Console.WriteLine("\n Press any key to continue.");
        //    Console.ReadKey();
        //}

        private static void LINQtoXmlDeleteNode()
        {
            string myXML = @"<Departments>
                       <Department>Support</Department>
                       <Department>Account</Department>
                       <Department>Sales</Department>
                       <Department>Pre-Sales</Department>
                       <Department>Marketing</Department>
                       <Department>Finance</Department>
                       </Departments>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            xdoc.Descendants().Where(s => s.Value == "Sales").Remove();

            var result = xdoc.Element("Departments").Descendants();
            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name - " + item.Value);
            }
            Console.WriteLine("\n Press any key to continue.");
            Console.ReadKey();
        }
    }
}
