using AutomobileRentals.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
    
namespace AutomobileRentals.EntityFramework.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingStatus> BookingsStatus { get; set; }
        public DbSet<CarStatus> CarStatus { get; set; }
        public DbSet<CarType> carTypes { get; set; }
        public DbSet<PaymentStatus> PaymentStatus { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Payment> payments { get; set; }

    }
}
