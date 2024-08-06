namespace AutomobileRentals.EntityFramework.Models
{
    public class BookingStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }

        //navigation property
        public virtual List<Booking> Bookings { get; set; }
    }
}
