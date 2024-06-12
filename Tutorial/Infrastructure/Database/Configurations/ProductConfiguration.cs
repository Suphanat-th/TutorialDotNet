using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Databse.Configurations;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder
            .HasKey(x => x.Id);
            
        builder
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();


        builder
            .Property(x => x.product_name_th)
            .IsRequired()
            .HasMaxLength(255);

        builder
            .Property(x => x.product_name_en)
            .IsRequired()
            .HasMaxLength(255);


        builder.HasIndex(x => x.Category_Id);


        builder.ToTable("Products");

    }
}