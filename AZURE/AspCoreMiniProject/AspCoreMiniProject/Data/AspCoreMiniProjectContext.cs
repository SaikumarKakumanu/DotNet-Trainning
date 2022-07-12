using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspCoreMiniProject;

namespace AspCoreMiniProject.Data
{
    public class AspCoreMiniProjectContext : DbContext
    {
        public AspCoreMiniProjectContext (DbContextOptions<AspCoreMiniProjectContext> options)
            : base(options)
        {
        }

        public DbSet<AspCoreMiniProject.Product> Product { get; set; }
    }
}
