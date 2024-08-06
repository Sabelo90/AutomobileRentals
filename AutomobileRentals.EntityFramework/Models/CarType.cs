namespace AutomobileRentals.EntityFramework.Models
{
    public class CarType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //navigation property
        public virtual List<Vehicle> Vehicles { get; set; }

    }
}
