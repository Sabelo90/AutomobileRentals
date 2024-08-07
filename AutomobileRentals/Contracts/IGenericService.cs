namespace AutomobileRentals.Contracts
{
    public interface IGenericService<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int? id);
        Task RemoveAsync(int? id);
        Task UpdateAsync(T? entity);
    }
}
