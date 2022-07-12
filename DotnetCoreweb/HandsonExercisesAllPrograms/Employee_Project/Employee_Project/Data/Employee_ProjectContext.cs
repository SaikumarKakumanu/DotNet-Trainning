using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employee_Project.Models;

namespace Employee_Project.Data
{
    public class Employee_ProjectContext : DbContext
    {
        public Employee_ProjectContext (DbContextOptions<Employee_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Employee_Project.Models.Employee>? Employee { get; set; }
    }
}
