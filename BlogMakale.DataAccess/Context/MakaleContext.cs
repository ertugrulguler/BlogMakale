using BlogMakale.Entities.EntityClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogMakale.DataAccess.Context
{
    public class MakaleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-DCF48B5;Database=BlogMakaleDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
