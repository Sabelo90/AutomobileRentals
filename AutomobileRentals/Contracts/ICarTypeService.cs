using AutomobileRentals.EntityFramework.Models;
using AutomobileRentals.Models;
using AutomobileRentals.Models.VehicleModels;
using AutomobileRentals.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace AutomobileRentals.Contracts
{
    public interface ICarTypeService : IGenericService<CarType>
    {
        Task<IEnumerable<CarType>> GetCarTypes();
       // Task<PagedResult<VehicleDTO>> GetCarTypes([FromQuery] QueryParameters queryParameters);
        //Task<Vehicle> GetCarType(int id);
        //Task<bool>  PutCarType(int id, Vehicle carType);
        //Task <Vehicle> PostCarType(CarType carType);
        //Task<bool> DeleteCarType(int id);
        //Task<bool> CarTypeExists(int id);
    }
}
