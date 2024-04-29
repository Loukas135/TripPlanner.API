﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TripPlanner.API.Contracts;
using TripPlanner.API.Data;

namespace TripPlanner.API.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly TripPlannerDbContext _context;
        private readonly IMapper _mapper;

        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            
            var record = await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            _context.Remove(entity);
            await _context.SaveChangesAsync();   
        }

        public async Task<bool> ExistsAsync(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int? id)
        {
            if (id is null)
            {
                return null;
            }
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
			_context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
