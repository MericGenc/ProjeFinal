using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjeFinal.Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeFinal.DataAcsess.Concreate.EntityFremeworkCore.Mappings
{
    public class ProductImageMap : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable(@"ProductImages", @"dbo");
            builder.HasKey(d => d.Id);

            builder.Property(d => d.AddedBy).HasColumnName("AddedBy");
            builder.Property(d => d.AddedDate).HasColumnName("AddedDate");
            builder.Property(d => d.FileName).HasColumnName("FileName");
            builder.Property(d => d.FilePath).HasColumnName("FilePath");
            builder.Property(d => d.ProductId).HasColumnName("ProductId");
        }

    }
}
