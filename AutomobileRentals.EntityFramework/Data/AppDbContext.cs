using AutomobileRentals.EntityFramework.Data.SeedData;
using AutomobileRentals.EntityFramework.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Reflection.Emit;

namespace AutomobileRentals.EntityFramework.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingStatus> BookingsStatus { get; set; }
        public DbSet<CarStatus> CarStatus { get; set; }
        public DbSet<CarType> carTypes { get; set; }
        public DbSet<PaymentStatus> PaymentStatus { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Payment> payments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new IdentityRoleConfiguation());
            builder.ApplyConfiguration(new CarTypeConfiguration());
        }

    }

}
