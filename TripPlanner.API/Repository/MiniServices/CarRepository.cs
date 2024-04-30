using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TripPlanner.API.Contracts;
using TripPlanner.API.Contracts.Generics;
using TripPlanner.API.Contracts.MiniServices;
using TripPlanner.API.Data;
using TripPlanner.API.Repository.Generics;

namespace TripPlanner.API.Repository.MiniServices
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        public CarRepository(TripPlannerDbContext context, IMapper mapper,UserManager<ApiUser>userManager) : base(context, mapper,userManager)
        {
        }
    }
}
