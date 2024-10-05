using AutomobileRentals.EntityFramework.Models;
using AutomobileRentals.Models;
using AutomobileRentals.Models.VehicleModels;
using AutomobileRentals.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace AutomobileRentals.Contracts
{
    public interface IVehicleService : IGenericService<Vehicle>
    {
        Task<IEnumerable<Vehicle>> GetVehicles();
        Task<PagedResult<VehicleDTO>> GetVehicles([FromQuery] QueryParameters queryParameters);
        Task<Vehicle> GetVehicle(int id);
        Task<bool>  PutVehicle(int id, Vehicle vehicle);
        Task <Vehicle> PostVehicle(Vehicle vehicle);
        Task<bool> DeleteVehicle(int id);
        Task<bool> VehicleExists(int id);
    }
}
