using AutomobileRentals_EntityFramework.Data;
using AutomobileRentalsCore.Models;
using static AutomobileRentalsCore.Contracts.ResourceContracts;

namespace AutomobileRentalsCore.Resources
{
    public class PersonResource : IPersonResource
    {
        private readonly AppDbContext _dbContext;
        public PersonResource(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public Task<PersonModel> AddAsync(PersonModel item)
        {
            throw new NotImplementedException();
        }

        public Task<PersonModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PersonModel> RemoveAsync(PersonModel item)
        {
            throw new NotImplementedException();
        }

        public Task<PersonModel[]> RemoveListAsync(int[] id)
        {
            throw new NotImplementedException();
        }

        public Task<PersonModel> UpdateAsync(PersonModel item)
        {
            throw new NotImplementedException();
        }
    }
}
