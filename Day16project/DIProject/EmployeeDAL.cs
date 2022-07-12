﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIProject
{
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employeelist = new List<Employee>();
            //normllay we get data from some persistent object(files or databases)
            //but we will hardcode the data (since we do not have any database)
            employeelist.Add(new Employee() { Id = 1, Name = "RaviKumar", Department = "IT" });
            employeelist.Add(new Employee() { Id = 2, Name = "Sheetal", Department = "HR" });
            employeelist.Add(new Employee() { Id = 3, Name = "Rajesh", Department = "Finance" });
            return employeelist;
        }

    }
}
