using Marketplace.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.Dal
{
    public class ContextDB : DbContext
    {
        public DbSet<UserDB> Users { get; set; }
        public DbSet<CourierDB> Courses { get; set; }
        public DbSet<OrderDB> Orders { get; set; }
        public DbSet<ProductDB> Products { get; set; }
        public DbSet<PVZDB> PVZs { get; set; }
        public DbSet<SellerDB> Sellers { get; set;}

        public ContextDB() 
        { 
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=usersdb;Username=postgres;Password=AveSatan666");
        }
    }
}
