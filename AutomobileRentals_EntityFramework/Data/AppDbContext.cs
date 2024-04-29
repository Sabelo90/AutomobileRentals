using AutomobileRentals_EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace AutomobileRentals_EntityFramework.Data
{
   public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
       
        public virtual DbSet<person> people { get; set; }
        public virtual DbSet<booking> bookings { get; set; }
        public virtual DbSet<vehicle> vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<person>(entity =>
            {
                entity.ToTable("People");
                entity.HasKey(k => k.per_id);
                entity.Property(p => p.per_email).IsRequired();
                entity.Property(p => p.per_username).IsRequired();
                entity.Property(P => P.per_idno).IsRequired();
                entity.Property(P => P.per_passwordhash).IsRequired();
            });

            modelBuilder.Entity<vehicle>(entity =>
            {
                entity.ToTable("Vehicles");
                entity.HasKey(k => k.veh_id);
                entity.Property(p => p.veh_brand).IsRequired();
                entity.Property(p => p.veh_priceperday).IsRequired().HasColumnType("decimal(19, 5)");
                entity.Property(p => p.veh_model).IsRequired();
                entity.Property(p => p.veh_year).IsRequired();
            });

            modelBuilder.Entity<booking>(entity =>
            {
                entity.ToTable("Bookings");
                entity.HasIndex(e => e.bok_ref_vehicle, "ix_bok_ref_vehicle");
                entity.HasIndex(e => e.bok_ref_person, "ix_bok_ref_person");
                entity.HasKey(k => k.bok_id).HasName("pk_booking");
                entity.Property(p => p.bok_startdate).IsRequired();
                entity.Property(p => p.Bok_enddate).IsRequired();
                entity.Property(p => p.bok_totalprice).IsRequired().HasColumnType("decimal(19, 5)");

                entity.HasOne(e => e.bok_ref_personNavigation).
                WithMany(e => e.personBookings).HasForeignKey(e => e.bok_ref_person);
                
                entity.HasOne(e => e.bok_ref_vehicleNavigation).
                WithMany(e => e.vehicleBookings).HasForeignKey(e => e.bok_ref_vehicle);
            });

            modelBuilder.Entity<vehicle>(entity =>
            {
                entity.ToTable("Vehicles");
              
                entity.HasKey(k => k.veh_id).HasName("pk_vehicle");
                entity.Property(p => p.veh_brand).IsRequired();
                entity.Property(p => p.veh_priceperday).IsRequired();
                entity.Property(p => p.veh_model).IsRequired();
                entity.Property(p => p.veh_year).IsRequired();

            });

        }
    }
}
