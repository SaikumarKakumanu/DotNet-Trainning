using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Practice_Employee.Models;

namespace Practice_Employee.Data
{
    public class Practice_EmployeeContext : DbContext
    {
        public Practice_EmployeeContext (DbContextOptions<Practice_EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<Practice_Employee.Models.Employee> Employee { get; set; }
    }
}
