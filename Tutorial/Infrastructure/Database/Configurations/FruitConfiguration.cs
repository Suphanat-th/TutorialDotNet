using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.Configurations
{
    public class FruitConfiguration : IEntityTypeConfiguration<Fruit>
    {
        public void Configure(EntityTypeBuilder<Fruit> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.Name_th)
                .IsRequired()
                .HasMaxLength(150);
            builder
                .Property(x => x.Name_en)
                .IsRequired()
                .HasMaxLength(150);

            builder
                .Property(x => x.ContentType)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}