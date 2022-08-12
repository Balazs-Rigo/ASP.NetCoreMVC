using InAndOut.Models;
using InAndOut.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace InAndOut.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeviceVM>().HasNoKey();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Device> Devices { get; set; }

        public DbSet<InAndOut.Models.ViewModels.DeviceVM> DeviceVM { get; set; }
    }
}
