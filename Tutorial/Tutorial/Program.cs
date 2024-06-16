using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Tutorial;
using Tutorial.Database;
using Tutorial.Models.Register;
using Tutorial.Services;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());

// Add  services of DbContext with Sqlite
builder.Services.AddDbContext<DataContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("Sqlite")));

// Infrastucture
builder.Services.AddScoped<IUserRepository, UserRepository>();


// Core
builder.Services.AddScoped<IServicesUser, ServicesUser>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
