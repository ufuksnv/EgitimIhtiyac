using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LLU1JQO\\SQLEXPRESS;database=OkulDB;integrated security=true;");
        }

        public DbSet<Member>? Members { get; set; }
        public DbSet<Need>? Needs { get; set; }
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<About>? Abouts { get; set; }
        public DbSet<Contact>? Contacts { get; set; }

    }
}
