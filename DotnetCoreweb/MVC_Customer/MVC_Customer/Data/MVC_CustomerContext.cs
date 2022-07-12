using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Customer.Models;

namespace MVC_Customer.Data
{
    public class MVC_CustomerContext : DbContext
    {
        public MVC_CustomerContext (DbContextOptions<MVC_CustomerContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Customer.Models.Customer>? Customer { get; set; }
    }
}
