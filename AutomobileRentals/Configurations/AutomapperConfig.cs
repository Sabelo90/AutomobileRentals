using AutoMapper;
using AutomobileRentals.EntityFramework.Models;
using AutomobileRentals.Models.VehicleModels;

namespace AutomobileRentals.Configurations
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
                CreateMap<Vehicle , VehicleDTO>();
        }
    }
}
