using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjeFinal.Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeFinal.DataAcsess.Concreate.EntityFremeworkCore.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(@"Productss", @"dbo");
            builder.HasKey(d => d.Id);

            builder.Property(d => d.AddedBy).HasColumnName("AddedBy");
            builder.Property(d => d.AddedDate).HasColumnName("AddedDate");
            builder.Property(d => d.CategoryId).HasColumnName("CategoryId");
            builder.Property(d => d.Explanation).HasColumnName("Explenation");
            builder.Property(d => d.Height).HasColumnName("Height");
            builder.Property(d => d.Name).HasColumnName("Name");
            builder.Property(d => d.Weight).HasColumnName("Weight");
            builder.Property(d => d.Width).HasColumnName("Width");
        }
    }
}
