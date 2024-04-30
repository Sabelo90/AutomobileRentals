using AutomobileRentals_EntityFramework.Models;

namespace AutomobileRentalsCore.Models
{
    public class VehicleModel
    {
        public int veh_id { get; set; }
        public string veh_brand { get; set; }
        public string veh_model { get; set; }
        public int veh_year { get; set; }
        public decimal veh_priceperday { get; set; }
        public bool veh_is_available { get; set; }

        public VehicleModel() { }

        public VehicleModel(VehicleModel model)
        {
            veh_id = model.veh_id;
            veh_brand = model.veh_brand;
            veh_model = model.veh_model;
            veh_priceperday = model.veh_priceperday;
            veh_year = model.veh_year;
            veh_is_available = model.veh_is_available;
        }

        public VehicleModel(vehicle model)
        {
            veh_id = model.veh_id;
            veh_brand = model.veh_brand;
            veh_model = model.veh_model;
            veh_priceperday = model.veh_priceperday;
            veh_year = model.veh_year;
            veh_is_available = model.veh_is_available;
        }

        public vehicle ToEntity()
        {
            return new vehicle
            {
                veh_id = veh_id,
                veh_brand = veh_brand,
                veh_model = veh_model,
                veh_priceperday = veh_priceperday,
                veh_year = veh_year,
                veh_is_available = veh_is_available
            };
        }
    }

}
