using FurniWeb.App.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FurniWeb.App.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeePosition> EmployeePositions { get; set; }
        public DbSet<Furniture> Furnitures { get; set; }

        public DbSet<Position> Positions { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }

        public DbSet<Subscribe> Subscribe { get; set; }



        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

    }
}
