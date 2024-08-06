using System.ComponentModel.DataAnnotations.Schema;

namespace AutomobileRentals.EntityFramework.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal TotalCost { get; set; }

        //navigation property user
        [ForeignKey(nameof(UserId))]
        public int UserId { get; set; }
        public User User { get; set; }

        //navigation property Vehicle
        [ForeignKey(nameof(VehicleId))]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        //navigation propery BookingStatus

        [ForeignKey(nameof(BookingStatusId))]
        public int BookingStatusId { get; set; }
        public BookingStatus BookingStatus { get; set; } // Pending, Ongoing, Completed, Cancelled
    }
}
