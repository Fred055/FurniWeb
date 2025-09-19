using FurniWeb.App.Constants;
using FurniWeb.App.Context;
using FurniWeb.App.Repository.Abstracts.R_Position;
using FurniWeb.App.Repository.Abstracts.RContact;
using FurniWeb.App.Repository.Abstracts.REmployee;
using FurniWeb.App.Repository.Concretes.RContact;
using FurniWeb.App.Repository.Concretes.REmployee;
using FurniWeb.App.Repository.Concretes.RPosition;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IContactReadRepository, ContactReadRepository>();
builder.Services.AddScoped<IContactWriteRepository, ContactWriteRepository>();
builder.Services.AddScoped<IPositionReadRepository, PositionReadRepository>();
builder.Services.AddScoped<IPositionWriteRepository, PositionWriteRepository>();
builder.Services.AddScoped<IEmployeeReadRepository, EmployeeReadRepository>();
builder.Services.AddScoped<IEmployeeWriteRepository, EmployeeWriteRepository>();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString(ConnectionNames.DefaultConnectionName));
});

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

app.MapAreaControllerRoute(
                name: "admin",
                areaName: "admin",
                pattern: "admin/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
