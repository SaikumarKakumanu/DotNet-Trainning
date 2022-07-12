using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HandsOn_Ajax.Models;

namespace HandsOn_Ajax.Data
{
    public class HandsOn_AjaxContext : DbContext
    {
        public HandsOn_AjaxContext (DbContextOptions<HandsOn_AjaxContext> options)
            : base(options)
        {
        }

        public DbSet<HandsOn_Ajax.Models.Student>? Student { get; set; }
    }
}
