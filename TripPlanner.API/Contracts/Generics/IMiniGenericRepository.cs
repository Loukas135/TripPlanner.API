using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace TripPlanner.API.Contracts.Generics
{
    public interface IMiniGenericRepository<T> where T : class
    {
        Task<T> AddMiniAsync(T entity);
        Task UpdateMiniAsync(T entity);
        Task DeleteMiniAsync(int id);
        Task<List<T>> GetAllMiniAsync();
        Task<T> GetMiniAsync(int? id);
        Task<bool> ExistsMiniAsync(int id);
    }
}
