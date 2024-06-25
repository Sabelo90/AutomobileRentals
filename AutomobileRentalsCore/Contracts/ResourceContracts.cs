using AutomobileRentalsCore.Models;
using AutomobileRentalsCore.Resources;

namespace AutomobileRentalsCore.Contracts
{
    public class ResourceContracts
    {
        public interface IBaseResource<T> where T : class
        {
            Task<T> AddAsync(T item);
            Task<T> RemoveAsync(T item);
            Task<T[]> RemoveListAsync(int[] id);
            Task<T> GetAsync(int id);
            Task<T> UpdateAsync(T item);
        }

        public interface IPersonResource : IBaseResource<PersonModel>
        {
            

        } 
        public interface IVehicleResource : IBaseResource<VehicleModel>
        {

        }

        public interface IBookingResource : IBaseResource<BookingModel>
        {
           
        }
    }
}
