using AutomobileRentals.Contracts;
using AutomobileRentals.EntityFramework.Data;
using Microsoft.EntityFrameworkCore;

namespace AutomobileRentals.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly AppDbContext _context;

        public GenericService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int? id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(int? id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }

        }

        public async Task UpdateAsync(T? entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();

        }
    }
}
