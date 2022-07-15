using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirst
{
    class Program
    {
        static ZensarDBEntities dbcontext = new ZensarDBEntities();
        static tblEmployee emp = new tblEmployee();

        public void DisplayEmp()
        {
            var deptlist = from d in dbcontext.tblEmployees
                           select d;

            foreach (var v in deptlist)
            {
                Console.WriteLine(v.Empid + "  " + v.EmpName + "  " + v.Gender + "  " + v.Salary + "  " + v.Email + "  " + v.DId + "  " + v.Phoneno);
            }
        }
        static void Main(string[] args)
        {
           Program p = new Program();
            p.DisplayEmp();
            Console.ReadLine();
        }
    }
}
