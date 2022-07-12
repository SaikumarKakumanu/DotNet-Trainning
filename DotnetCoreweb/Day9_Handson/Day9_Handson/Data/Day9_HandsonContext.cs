using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day9_Handson.Models;

namespace Day9_Handson.Data
{
    public class Day9_HandsonContext : DbContext
    {
        public Day9_HandsonContext (DbContextOptions<Day9_HandsonContext> options)
            : base(options)
        {
        }

        public DbSet<Day9_Handson.Models.Student>? Student { get; set; }
    }
}
