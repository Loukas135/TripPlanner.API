using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Contracts;
using TripPlanner.API.Data;
using TripPlanner.API.Data.Services;

namespace TripPlanner.API.Repository
{
	public class ServiceRepository : GenericRepository<Service>, IServiceRepository
	{
		private readonly TripPlannerDbContext _context;
		private readonly IMapper _mapper;

		public ServiceRepository(TripPlannerDbContext context, IMapper mapper)
        {
			this._context = context;
			this._mapper = mapper;
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
		
		//public Task<List<Service>> FilterByType(string type)
		//{
		//
		//}
	}
}
