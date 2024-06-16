using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Tutorial.Database.Configurations;
using Tutorial.Database.DTOs;

namespace Tutorial.Database;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Users> users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Sqlite.db", options =>
        {
            options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
        });
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new UserConfiguration());
        base.OnModelCreating(builder);
    }

}
