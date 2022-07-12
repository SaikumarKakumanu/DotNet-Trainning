using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI_Ajax_Jqurey.Models;

namespace WebAPI_Ajax_Jqurey.Data
{
    public class WebAPI_Ajax_JqureyContext : DbContext
    {
        public WebAPI_Ajax_JqureyContext (DbContextOptions<WebAPI_Ajax_JqureyContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI_Ajax_Jqurey.Models.Product>? Product { get; set; }
    }
}
