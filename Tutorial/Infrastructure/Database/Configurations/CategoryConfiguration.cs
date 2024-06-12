using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Databse.Configurations;
public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder
            .HasKey(x => x.Id);


        builder
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();
            
        builder
            .Property(x => x.cat_name_en)
            .IsRequired()
            .HasMaxLength(155);


        builder
            .Property(x => x.cat_name_th)
            .IsRequired()
            .HasMaxLength(155);

        builder
            .ToTable("Categorys");
    }
}