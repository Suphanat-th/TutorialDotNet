using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tutorial.Database.DTOs;

namespace Tutorial.Database.Configurations;
public class UserConfiguration : IEntityTypeConfiguration<Users>
{
    public void Configure(EntityTypeBuilder<Users> builder)
    {
        builder
            .HasKey(x => x.id);

        builder
            .Property(x => x.id)
            .ValueGeneratedOnAdd();

        builder
            .Property(x => x.username)
            .IsRequired()
            .HasMaxLength(50);

        builder
            .Property(x => x.password)
            .IsRequired()
            .HasMaxLength(50);

        builder
            .ToTable("Users");
    }
}