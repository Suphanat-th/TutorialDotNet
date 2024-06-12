using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Databse.Configurations;
public class ProductDetailConfiguration : IEntityTypeConfiguration<ProductDetail>
{
    public void Configure(EntityTypeBuilder<ProductDetail> builder)
    {
        builder
            .HasKey(x => x.Id);

        builder
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder
            .Property(x => x.product_detail_name_th)
            .IsRequired()
            .HasMaxLength(255);

        builder
            .Property(x => x.product_detail_name_en)
            .IsRequired()
            .HasMaxLength(255);

        builder
            .Property(x => x.product_detail_name_image)
            .HasMaxLength(255);

    }
}