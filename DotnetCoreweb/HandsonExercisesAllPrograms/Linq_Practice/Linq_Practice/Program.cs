using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Linq_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "Anil", "Sharma", "Abdullah", "Imran", "Siva", "Naresh", "Suresh", "Suman" };
            UsingLINQ(Names);
            Console.WriteLine("---------------------------------------");
            UsingLinqExtensions(Names);
            Console.WriteLine("---------------------------------------");
            UsingLinqFunctions(Names);
            Console.WriteLine("---------------------------------------");
            UsingLinqAnynomusMethod(Names);
            Console.WriteLine("---------------------------------------");
            LinqToReadXML();
            Console.WriteLine("---------------------------------------");
            LinqToXmlAddNode();
            Console.WriteLine("---------------------------------------");
            LinqToXmlDeleteNode();
            Console.ReadLine();
        }
        private static void UsingLINQ(string[] names)
        {
            IEnumerable<string> query = from e in names
                                        where e.Length == 5
                                        orderby e
                                        select e.ToUpper();
            foreach (var item in query)
                Console.WriteLine(item);
        }
        private static void UsingLinqExtensions(string[] names)
        {
            IEnumerable<string> query = names.Where(c => c.Length == 5).OrderBy(c => c).Select(c => c.ToUpper());
            foreach(var item in query)
                Console.WriteLine(item);

        }
        private static void UsingLinqFunctions(string[] names)
        {
            Func<string, bool> query1 = x => x.Length == 5;
            Func<string, string> query2 = x => x;
            Func<string, string> query3 = x => x.ToUpper();

            IEnumerable<string> query = names.Where(query1).OrderBy(query2).Select(query3);
            foreach(var item in query)
                Console.WriteLine(item);
        }
        private static void UsingLinqAnynomusMethod(string[] names)
        {
            Func<string, bool> query1 = delegate (string s)
                {
                    return s.Length == 5;
                };
            Func<string, string> query2 = delegate (string s)
                {
                    return s;
                };
            Func<string, string> query3 = delegate (string s)
                {
                    return s.ToUpper();
                };

            IEnumerable<string> query = names.Where(query1).OrderBy(query2).Select(query3);

            foreach(var item in query)
                Console.WriteLine(item);
        }
        private static void LinqToReadXML()
        {
            string MyXML = @"<Departments>
                             <Department>Account</Department>
                             <Department>Sales</Department>
                             <Department>Pre-Sales</Department>
                             <Department>Marketing</Department>
                             </Departments>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(MyXML);

            var result = xdoc.Element("Departments").Descendants();
            foreach(XElement item in result)
            {
                Console.WriteLine("Department Name - " +item.Value);
            }
            
        }
        private static void LinqToXmlAddNode()
        {
            string MyXML = @"<Departments>
                             <Department>Accounts</Department>
                             <Department>Sales</Department>
                             <Department>Pre-Sales</Department>
                             <Department>Marketing</Department>
                             </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(MyXML);

            xdoc.Element("Departments").Add(new XElement("Department", "Finace"));
            xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));

            var result = xdoc.Element("Departments").Descendants();
            foreach(XElement item in result)
            {
                Console.WriteLine("Department Name - "+item.Value);
            }
        }
        private static void LinqToXmlDeleteNode()
        {
            string MyXML = @"<Departments>
                             <Department>Support</Department>
                             <Department>Accounts</Department>
                             <Department>Sales</Department>
                             <Department>Pre-Sales</Department>
                             <Department>Marketing</Department>
                             <Department>Finace</Department>
                             </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(MyXML);

            xdoc.Descendants().Where(x => x.Value == "Sales").Remove();
            var result = xdoc.Element("Departments").Descendants();
            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name - " + item.Value);
            }
        }
    }
}
