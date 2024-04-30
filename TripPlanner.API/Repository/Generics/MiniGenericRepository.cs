using TripPlanner.API.Contracts.Generics;

namespace TripPlanner.API.Repository.Generics
{
    public class MiniGenericRepository<T> : IMiniGenericRepository<T> where T : class
    {
        public Task<T> AddMiniAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMiniAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsMiniAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllMiniAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetMiniAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMiniAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
