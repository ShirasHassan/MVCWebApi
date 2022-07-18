using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Test_Neudesic.Models;

namespace Test_Neudesic.Services
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("name=ProductDb")
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Category>().ToTable("Category");
        }
    }
}