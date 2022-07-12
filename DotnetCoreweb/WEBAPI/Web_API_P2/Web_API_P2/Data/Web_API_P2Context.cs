using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_API_P2.Models;

namespace Web_API_P2.Data
{
    public class Web_API_P2Context : DbContext
    {
        public Web_API_P2Context (DbContextOptions<Web_API_P2Context> options)
            : base(options)
        {
        }

        public DbSet<Web_API_P2.Models.Customer>? Customer { get; set; }
    }
}
