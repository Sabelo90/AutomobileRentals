namespace AutomobileRentals.EntityFramework.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //nav prop 
        public virtual List<Payment> Payments { get; set; }
    }
}
