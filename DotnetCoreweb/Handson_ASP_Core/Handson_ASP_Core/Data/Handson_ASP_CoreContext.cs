using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Handson_ASP_Core.Models;

namespace Handson_ASP_Core.Data
{
    public class Handson_ASP_CoreContext : DbContext
    {
        public Handson_ASP_CoreContext (DbContextOptions<Handson_ASP_CoreContext> options)
            : base(options)
        {
        }

        public DbSet<Handson_ASP_Core.Models.Student>? Student { get; set; }
    }
}
