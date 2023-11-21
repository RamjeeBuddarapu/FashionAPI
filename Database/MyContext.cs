using FashionHexa.Entities;
using System.Collections.Generic;
namespace FashionHexa.Database
{
    public class MyContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<UserRatings> UserRatings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = MSI/DATAMODEL; Initial Catalog=EcomHexa ;User Id=Ramjee;Password=1234;TrustServerCertificate=true");
        }
    }
}
