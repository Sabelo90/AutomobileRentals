namespace AutomobileRentals_EntityFramework.Models
{
    public class vehicle
    {
        public int veh_id { get; set; }
        public string veh_brand { get; set; }
        public string veh_model { get; set; }
        public int veh_year { get; set; }
        public decimal veh_priceperday { get; set; }
        public bool veh_is_available { get; set; }

        public ICollection<booking> vehicleBookings { get; set; } = new List<booking>();

    }
}
