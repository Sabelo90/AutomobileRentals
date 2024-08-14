using AutoMapper;
using AutomobileRentals.EntityFramework.Models;
using AutomobileRentals.Models.AccountModels;
using AutomobileRentals.Models.VehicleModels;

namespace AutomobileRentals.Configurations
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
                CreateMap<Vehicle , VehicleDTO>().ReverseMap();
                CreateMap<User , SignUpDTO>().ReverseMap();
        }
    }
}
