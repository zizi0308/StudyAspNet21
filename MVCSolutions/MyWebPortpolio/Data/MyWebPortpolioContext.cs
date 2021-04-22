using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWebPortpolio.Models;

namespace MyWebPortpolio.Data
{
    public class MyWebPortpolioContext : DbContext
    {
        public MyWebPortpolioContext (DbContextOptions<MyWebPortpolioContext> options)
            : base(options)
        {
        }

        public DbSet<MyWebPortpolio.Models.Account> Account { get; set; }
    }
}
