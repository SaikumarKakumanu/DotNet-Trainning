using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Product.Models;

namespace MVC_Product.Data
{
    public class MVC_ProductContext : DbContext
    {
        public MVC_ProductContext (DbContextOptions<MVC_ProductContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Product.Models.Product>? Product { get; set; }
    }
}
