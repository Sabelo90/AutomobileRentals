using AutomobileRentals.Contracts;
using AutomobileRentals.EntityFramework.Data;
using AutomobileRentals.EntityFramework.Models;
using AutomobileRentals.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace AutomobileRentals.Services
{
    public class VehicleService : GenericService<Vehicle> , IVehicleService
    {
        public VehicleService(AppDbContext context) : base(context)
        {
                
        }
        // GET: api/Vehicles
        [HttpGet]
        public async Task<IEnumerable<Vehicle>> GetVehicles()
        {
            return await GetAllAsync();
        }

        // GET: api/Vehicles/5
        [HttpGet("{id}")]
        public async Task<Vehicle> GetVehicle(int id)
        {
            var vehicle = await GetByIdAsync(id);

            if (vehicle == null)
            {
                throw new NotFoundException(nameof(GetVehicle),id);
            }

            return vehicle;
        }

        // PUT: api/Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<bool> PutVehicle(int id, Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return false;
            }


            try
            {
                await UpdateAsync(vehicle);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VehicleExists(id))
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

        // POST: api/Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<Vehicle> PostVehicle(Vehicle vehicle)
        {
           var vehicleCreated =  await AddAsync(vehicle);

            return vehicleCreated;
        }

        // DELETE: api/Vehicles/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteVehicle(int id)
        {
            var vehicle = await GetByIdAsync(id);
            if (vehicle == null)
            {
                throw new NotFoundException(nameof(DeleteVehicle), id);
            }
            await  RemoveAsync(id);
            return true;
        }

        public async Task<bool> VehicleExists(int id)
        {
            var vehicle = await GetByIdAsync(id);
            return vehicle != null;
        }

    }
}
