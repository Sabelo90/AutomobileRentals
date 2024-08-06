namespace AutomobileRentals.EntityFramework.Models
{
    public class CarStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }

        //nav property
        public virtual List<Vehicle> Vehicles { get; set; }
    }
}
