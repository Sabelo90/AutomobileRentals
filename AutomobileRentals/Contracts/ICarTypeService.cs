using AutomobileRentals.EntityFramework.Models;
using AutomobileRentals.Models;
using AutomobileRentals.Models.CarTypeModels;
using AutomobileRentals.Models.VehicleModels;
using AutomobileRentals.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace AutomobileRentals.Contracts
{
    public interface ICarTypeService : IGenericService<CarType>
    {
        Task<IEnumerable<CarType>> GetCarTypes();
        Task<PagedResult<CarTypeDTO>> GetCarTypes([FromQuery] QueryParameters queryParameters);
        Task<CarType> GetCarType(int id);
        Task<bool> PutCarType(int id, CarType carType);
        Task<CarType> PostCarType(CarType carType);
        Task<bool> DeleteCarType(int id);
        Task<bool> CarTypeExists(int id);
    }
}
