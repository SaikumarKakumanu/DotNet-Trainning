// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string[] Names = { "Anil", "Sharma", "Abdullah", "Imran", "Siva", "Naresh", "Suresh", "Suman" };
//using linq
//usingLinq(Names);

//using linq Extensions
//usingLinqExtensions(Names);

//using linq functions
//UsingLinqFunctions(Names);

//using linq by delegates anonymusmethod
UsingLinqAnonymousMethods(Names);

//static void usingLinq(string[] names)
//{
//    IEnumerable<string> query = from s in names
//                                where s.Length==5
//                                orderby s
//                                select s.ToUpper();
//    foreach(var item in query)
//        Console.WriteLine(item);

//    Console.ReadLine();
//}

//static void usingLinqExtensions(string[] names)
//{
//    IEnumerable<string> query = names
//                                .Where(x => x.Length == 5)
//                                .OrderBy(x => x)
//                                .Select(x => x.ToUpper());
//    foreach(string name in query)
//        Console.WriteLine(name);

//    Console.ReadLine();
//}

//static void UsingLinqFunctions(string[] names)
//{
//    Func<string, bool> filter = x => x.Length == 5;
//    Func<string, string> extract = x => x;
//    Func<string, string> project = x => x.ToUpper();

//    IEnumerable<string> query = names.Where(filter)
//                                     .OrderBy(extract)
//                                     .Select(project);

//    foreach (string name in query)
//        Console.WriteLine(name);

//    Console.Read();

//}

static void UsingLinqAnonymousMethods(string[] names)
{
    Func<string, bool> filter = delegate (string s)
    {
        return s.Length == 5;
    };
    Func<string, string> extract = delegate (string s)
    {
        return s;
    };
    Func<string, string> project = delegate (string s)
    {
         return s.ToUpper();
    };

    IEnumerable<string> query = names.Where(filter)
                                     .OrderBy(extract)
                                     .Select(project);

    foreach (string name in query)
        Console.WriteLine(name);

    Console.Read();
}
