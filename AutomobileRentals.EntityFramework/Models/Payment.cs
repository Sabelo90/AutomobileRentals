using System.ComponentModel.DataAnnotations.Schema;

namespace AutomobileRentals.EntityFramework.Models
{
    public class Payment
    {
        public int Id { get; set; }

        [ForeignKey(nameof(BookingId))]

        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        //navigation property Booking
        [ForeignKey(nameof(BookingId))]
        public int BookingId { get; set; }
        public Booking booking { get; set; }

        //navigation property payment method
        public int PaymentMethodId { get; set; }
        public PaymentMethod Method { get; set; }

        //navigation propery Payment Status
        public int PaymentStatusId { get; set; }
        public PaymentStatus Status { get; set; } // Pending, Completed, Failed
    }

}
