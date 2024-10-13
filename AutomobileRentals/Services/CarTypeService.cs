using AutoMapper;
using AutomobileRentals.Contracts;
using AutomobileRentals.EntityFramework.Data;
using AutomobileRentals.EntityFramework.Models;
using AutomobileRentals.Exceptions;
using AutomobileRentals.Models;
using AutomobileRentals.Models.CarTypeModels;
using AutomobileRentals.Parameters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutomobileRentals.Services
{
    public class CarTypeService : GenericService<CarType>, ICarTypeService
    {
        public CarTypeService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<IEnumerable<CarType>> GetCarTypes()
        {
            return await GetAllAsync();
        }


        [HttpGet]
        public async Task<PagedResult<CarTypeDTO>> GetCarTypes([FromQuery] QueryParameters queryParameters)
        {
            return await GetAllAsync<CarTypeDTO>(queryParameters);
        }

        public async Task<CarType> GetCarType(int id)
        {
            var  carType = await GetByIdAsync(id);

            if (carType == null)
            {
                throw new NotFoundException(nameof(GetCarType), id);
            }

            return carType;
        }

       
        public async Task<bool> PutCarType(int id, CarType carType)
        {
            if (id != carType.Id)
            {
                return false;
            }


            try
            {
                await UpdateAsync(carType);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CarTypeExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }

            return false;
        }

        public async Task<CarType> PostCarType(CarType carType)
        {
            var carTypeCreated = await AddAsync(carType);

            return carTypeCreated;
        }

        public async Task<bool> DeleteCarType(int id)
        {
            var carType = await GetByIdAsync(id);
            if (carType == null)
            {
                throw new NotFoundException(nameof(DeleteCarType), id);
            }
            await  RemoveAsync(id);
            return true;
        }

        public async Task<bool> CarTypeExists(int id)
        {
            var vehicle = await GetByIdAsync(id);
            return vehicle != null;
        }

        
    }
}
