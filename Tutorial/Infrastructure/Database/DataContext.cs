﻿using Domain;
using Infrastructure.Database.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Infrastructure.Database;
public class DataContext : DbContext
{
    private readonly IConfiguration configurations;
    public DataContext(IConfiguration configuration,DbContextOptions<DataContext> options) : base(options)
    {
        this.configurations = configuration;
    }

    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(configurations.GetConnectionString("Sqlite"), options =>
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
