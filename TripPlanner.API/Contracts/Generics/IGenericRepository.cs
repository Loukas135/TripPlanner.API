﻿namespace TripPlanner.API.Contracts.Generics
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int? id);
        Task<bool> ExistsAsync(int id);

    }
}
