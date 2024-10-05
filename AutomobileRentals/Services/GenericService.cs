using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutomobileRentals.Contracts;
using AutomobileRentals.EntityFramework.Data;
using AutomobileRentals.Models;
using AutomobileRentals.Parameters;
using Microsoft.EntityFrameworkCore;

namespace AutomobileRentals.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public GenericService(AppDbContext appDbContext , IMapper mapper)
        {
            _context = appDbContext;
            _mapper = mapper;
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

        public async Task<PagedResult<TResult>> GetAllAsync<TResult>(QueryParameters queryParameters)
        {
            int totalSize = await _context.Set<T>().CountAsync();
            var result = await _context.Set<T>()
                .Skip(queryParameters.StartIndex)
                .Take(queryParameters.PageSize)
                .ProjectTo<TResult>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return new PagedResult<TResult>()
            {
                TotalCount = totalSize,
                PageIndex = queryParameters.StartIndex,
                PageSize = queryParameters.PageSize,
                Result = result
            };
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
