using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Contracts;
using TripPlanner.API.Data;
using TripPlanner.API.Data.Services;

namespace TripPlanner.API.Repository
{
	public class ServiceRepository : IServiceRepository
	{
		private readonly TripPlannerDbContext _context;
		private readonly IMapper _mapper;

		public ServiceRepository(TripPlannerDbContext context, IMapper mapper)
        {
			this._context = context;
			this._mapper = mapper;
		}
       public async Task<Service> GetAsync(int? id)
		{
            if (id is null)
            {
                return null;
            }
			return await _context.Services.FindAsync(id);
        }
        public async Task<Service> CreateAsync(Service service)
		{
			await _context.Services.AddAsync(service);
			await _context.SaveChangesAsync();
			return service;
		}

        public Task<List<Service>> FilterByType(string type)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Service>> SearchByName(string name)
		{
			var service = from s in _context.Services
						  where s.Name == name
						  select s;
			return service.ToList<Service>();
		}

		public Task<Service> AddAsync(Service entity)
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(Service entity)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<Service>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<bool> ExistsAsync(int id)
		{
			throw new NotImplementedException();
		}

		//public Task<List<Service>> FilterByType(string type)
		//{
		//
		//}
	}
}
