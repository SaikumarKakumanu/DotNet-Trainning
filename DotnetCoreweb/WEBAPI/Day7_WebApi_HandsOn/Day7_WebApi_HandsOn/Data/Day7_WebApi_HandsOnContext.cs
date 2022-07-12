using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day7_WebApi_HandsOn.Models;

namespace Day7_WebApi_HandsOn.Data
{
    public class Day7_WebApi_HandsOnContext : DbContext
    {
        public Day7_WebApi_HandsOnContext (DbContextOptions<Day7_WebApi_HandsOnContext> options)
            : base(options)
        {
        }

        public DbSet<Day7_WebApi_HandsOn.Models.Employee>? Employee { get; set; }
    }
}
