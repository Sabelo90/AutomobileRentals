using AutomobileRentals.EntityFramework.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomobileRentals.Models.VehicleModels
{
    public class VehicleDTO
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }

        public decimal RentalPricePerDay { get; set; }

        public int CarTypeId { get; set; }

        public int CarStatusId { get; set; }
    }
}
