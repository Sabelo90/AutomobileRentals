using AutomobileRentals_EntityFramework.Data;
using AutomobileRentalsCore.Models;
using static AutomobileRentalsCore.Contracts.ResourceContracts;

namespace AutomobileRentalsCore.Resources
{
    public class BookingResource : IBookingResource
    {
        private readonly AppDbContext _dbContext;
        public BookingResource(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public Task<BookingModel> AddAsync(BookingModel item)
        {
            throw new NotImplementedException();
        }

        public Task<BookingModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BookingModel> RemoveAsync(BookingModel item)
        {
            throw new NotImplementedException();
        }

        public Task<BookingModel[]> RemoveListAsync(int[] id)
        {
            throw new NotImplementedException();
        }

        public Task<BookingModel> UpdateAsync(BookingModel item)
        {
            throw new NotImplementedException();
        }
    }
}
