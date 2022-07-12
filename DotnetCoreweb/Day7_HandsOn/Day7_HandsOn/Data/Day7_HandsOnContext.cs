using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day7_HandsOn.Models;

namespace Day7_HandsOn.Data
{
    public class Day7_HandsOnContext : DbContext
    {
        public Day7_HandsOnContext (DbContextOptions<Day7_HandsOnContext> options)
            : base(options)
        {
        }

        public DbSet<Day7_HandsOn.Models.Department>? Department { get; set; }
    }
}
