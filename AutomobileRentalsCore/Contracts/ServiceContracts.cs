using AutomobileRentalsCore.Models;

namespace AutomobileRentalsCore.Contracts
{
    public class ServiceContracts
    {
        public interface IBaseService<T> where T : class
        {
            Task<T> PostAync(T model);
            Task<T> PutAsync(T model);
            Task<T> DeleteAsync(T model);
            Task<bool> DeleteListAsync(int[] id);
            Task<T> GetAsync(int id);

        }

        public interface OnEventsServiceBase<T> where T : class
        {
            Task<bool> onInsertAync(T model);
            Task<bool> onInsertCompletedAsync(T model);
            Task<bool> onUpdateAsync(T model);
            Task<bool> onUpdateCompletedAsync(T model);
            Task<bool> onSaveAsync(T model);
            Task<bool> onDeleteAsync(T model);
            Task<bool> onDeleteCompletedAsync(T model);
            Task<bool> onDeleteListAsync(int[] id);
            Task<bool> onDeleteListCompletedAsync(T[] models);

        }

        public interface IPersonService : IBaseService<PersonModel>, OnEventsServiceBase<PersonModel>
        {

        }

        public interface IVehicleService : IBaseService<VehicleModel>, OnEventsServiceBase<VehicleModel>
        {

        }

        public interface IBookingService : IBaseService<BookingModel>, OnEventsServiceBase<BookingModel>
        {

        }
    }
}
