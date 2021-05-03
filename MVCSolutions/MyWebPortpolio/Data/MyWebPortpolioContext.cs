using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWebPortpolio.Models;

namespace MyWebPortpolio.Data
{
    public class MyWebPortpolioContext : IdentityDbContext
    {
        public MyWebPortpolioContext (DbContextOptions<MyWebPortpolioContext> options)
            : base(options)
        {
        }

        public DbSet<MyWebPortpolio.Models.Contact> Contact { get; set; }
        public DbSet<MyWebPortpolio.Models.Account> Account { get; set; }

        public DbSet<MyWebPortpolio.Models.Board> Boards { get; set; }
        public DbSet<MyWebPortpolio.Models.Manage> Manages { get; set; }

    }
}
