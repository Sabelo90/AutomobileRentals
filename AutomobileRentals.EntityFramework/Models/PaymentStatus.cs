namespace AutomobileRentals.EntityFramework.Models
{
    public class PaymentStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }

        //nav prop
        public List<Payment> Payments { get; set; }
    }
}
