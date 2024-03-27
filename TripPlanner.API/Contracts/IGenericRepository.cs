namespace TripPlanner.API.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int? id);
        Task<bool> ExistsAsync(int id);

    }
}
