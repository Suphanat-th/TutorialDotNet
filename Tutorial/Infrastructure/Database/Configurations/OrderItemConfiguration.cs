using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Databse.Configurations;
public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder
            .HasKey(x => x.Id);

        builder
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder
            .Property(x => x.price)
            .IsRequired()
            .HasMaxLength(18);

        builder
            .Property(x => x.quantity)
            .IsRequired();

        builder
            .Property(x => x.Order_Id)
            .IsRequired()
            .HasMaxLength(155);
            

        builder.HasIndex(x => x.Order_Id);

        builder.ToTable("OrderItems");
        // builder.HasMany(x => x.Product).WithMany(x=>x.ProductDetail).has
    }
}