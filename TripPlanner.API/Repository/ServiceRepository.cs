using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Contracts;
using TripPlanner.API.Data;
using TripPlanner.API.Data.Services;
using TripPlanner.API.Repository.Generics;

namespace TripPlanner.API.Repository
{
	public class ServiceRepository : GenericRepository<Service>,IServiceRepository
	{
		private readonly TripPlannerDbContext context;
		private readonly IMapper mapper;
		private readonly UserManager<ApiUser> userManager;

		public ServiceRepository(TripPlannerDbContext context, IMapper mapper,UserManager<ApiUser>userManager):base(context,mapper,userManager)
        {
			this.context = context;
			this.mapper = mapper;
			this.userManager = userManager;
		}
        public Task<List<Service>> FilterByType(string type)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Service>> SearchByName(string name)
		{
			var service = from s in context.Services
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
