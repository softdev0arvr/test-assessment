using HartInterCivic.Models;
using Microsoft.EntityFrameworkCore;

namespace HartInterCivic.Data
{
    public class HartInterCivicDbContext : DbContext
    {
        public HartInterCivicDbContext(DbContextOptions<HartInterCivicDbContext> dbContextOptions) : base(dbContextOptions) 
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Performing Data Seeding for anyone to run application
            modelBuilder.Entity<TimerConfiguration>().HasData(new { Id = 1, Interval = 60, AutoStart = true});
            modelBuilder.Entity<Item>().HasData(new { Id = 1, Description = "Laptop", Count = 1 });
            modelBuilder.Entity<Item>().HasData(new { Id = 2, Description = "Mouse", Count = 2 });
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<TimerConfiguration> TimerConfigurations { get; set; }

    }
}
