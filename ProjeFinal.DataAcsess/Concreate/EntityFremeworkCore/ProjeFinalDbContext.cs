using Microsoft.EntityFrameworkCore;
using ProjeFinal.DataAcsess.Concreate.EntityFremeworkCore.Mappings;
using ProjeFinal.Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeFinal.DataAcsess.Concreate.EntityFremeworkCore
{
    public class ProjeFinalDbContext :  DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MERIC\MSSQLSERVERYENI;Database=ProjeFinalDb;integrated security=true;Connection Timeout=1800;MultipleActiveResultSets=True");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Category>(new CategoryMap());
            modelBuilder.ApplyConfiguration<Product>(new ProductMap());
            modelBuilder.ApplyConfiguration<ProductImage>(new ProductImageMap());
        }


    }
}
