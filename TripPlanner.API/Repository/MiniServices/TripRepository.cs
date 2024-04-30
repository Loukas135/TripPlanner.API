using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TripPlanner.API.Contracts.MiniServices;
using TripPlanner.API.Data;
using TripPlanner.API.Repository.Generics;

namespace TripPlanner.API.Repository.MiniServices
{
    public class TripRepository : GenericRepository<Trip>, ITripRepository
    {
        public TripRepository(TripPlannerDbContext context, IMapper mapper,UserManager<ApiUser> userManager) : base(context, mapper, userManager)
        { 

        }
    }
}
