using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Databse.Configurations;
public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder
            .HasKey(x => x.Id);


        builder
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();
            
        builder
            .Property(x => x.lat)
            .IsRequired()
            .HasMaxLength(18);

            
        builder
            .Property(x => x.lng)
            .IsRequired()
            .HasMaxLength(18);
            
        builder
            .Property(x => x.city)
            .IsRequired()
            .HasMaxLength(155);
            
        builder
            .Property(x => x.postal_code)
            .IsRequired()
            .HasMaxLength(5);

        builder
            .ToTable("Address");
    }
}