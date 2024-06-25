using AutomobileRentalsCore.Models;
using static AutomobileRentalsCore.Contracts.ResourceContracts;

namespace AutomobileRentalsCore.Resources
{
    public class VehicleResource : IVehicleResource
    {
        public Task<VehicleModel> AddAsync(VehicleModel item)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleModel> RemoveAsync(VehicleModel item)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleModel[]> RemoveListAsync(int[] id)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleModel> UpdateAsync(VehicleModel item)
        {
            throw new NotImplementedException();
        }
    }
}
