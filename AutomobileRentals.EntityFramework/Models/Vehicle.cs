using System.ComponentModel.DataAnnotations.Schema;

namespace AutomobileRentals.EntityFramework.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }

        public decimal RentalPricePerDay { get; set; }

        [ForeignKey(nameof(CarTypeId))]
        public int CarTypeId { get; set; }
        public CarType Type { get; set; }

        public int CarStatusId { get; set; }
        public CarStatus CarStatus { get; set; } // Available, Rented, Maintenance
    }
}
