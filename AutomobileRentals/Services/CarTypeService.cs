using AutoMapper;
using AutomobileRentals.Contracts;
using AutomobileRentals.EntityFramework.Data;
using AutomobileRentals.EntityFramework.Models;

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
        //// GET: api/Vehicles
        //[HttpGet]
        //public async Task<IEnumerable<Vehicle>> GetVehicles()
        //{
        //    return await GetAllAsync();
        //}

        //// GET: api/Vehicles
        //[HttpGet]
        //public async Task<PagedResult<VehicleDTO>> GetVehicles([FromQuery] QueryParameters queryParameters)
        //{
        //    return await GetAllAsync<VehicleDTO>(queryParameters); 
        //}

        //// GET: api/Vehicles/5
        //[HttpGet("{id}")]
        //public async Task<Vehicle> GetVehicle(int id)
        //{
        //    var vehicle = await GetByIdAsync(id);

        //    if (vehicle == null)
        //    {
        //        throw new NotFoundException(nameof(GetVehicle),id);
        //    }

        //    return vehicle;
        //}

        //// PUT: api/Vehicles/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<bool> PutVehicle(int id, Vehicle vehicle)
        //{
        //    if (id != vehicle.Id)
        //    {
        //        return false;
        //    }


        //    try
        //    {
        //        await UpdateAsync(vehicle);
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!await VehicleExists(id))
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return false;
        //}

        //// POST: api/Vehicles
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<Vehicle> PostVehicle(Vehicle vehicle)
        //{
        //   var vehicleCreated =  await AddAsync(vehicle);

        //    return vehicleCreated;
        //}

        //// DELETE: api/Vehicles/5
        //[HttpDelete("{id}")]
        //public async Task<bool> DeleteVehicle(int id)
        //{
        //    var vehicle = await GetByIdAsync(id);
        //    if (vehicle == null)
        //    {
        //        throw new NotFoundException(nameof(DeleteVehicle), id);
        //    }
        //    await  RemoveAsync(id);
        //    return true;
        //}

        //public async Task<bool> VehicleExists(int id)
        //{
        //    var vehicle = await GetByIdAsync(id);
        //    return vehicle != null;
        //}

    }
}
