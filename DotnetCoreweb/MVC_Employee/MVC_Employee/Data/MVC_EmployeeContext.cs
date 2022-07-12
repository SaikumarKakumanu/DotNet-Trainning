using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Employee.Models;

namespace MVC_Employee.Data
{
    public class MVC_EmployeeContext : DbContext
    {
        public MVC_EmployeeContext (DbContextOptions<MVC_EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Employee.Models.Employee>? Employee { get; set; }
    }
}
