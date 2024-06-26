using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.Configurations;
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
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