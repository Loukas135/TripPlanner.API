using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TripPlanner.API.Contracts.MiniServices;
using TripPlanner.API.Data;
using TripPlanner.API.Repository.Generics;

namespace TripPlanner.API.Repository.MiniServices
{
    public class RoomRepository : GenericRepository<Room>, IRoomRepository
    {
        private readonly TripPlannerDbContext context;
        private readonly IMapper mapper;
        private readonly UserManager<ApiUser> userManager;
        public RoomRepository(TripPlannerDbContext context, IMapper mapper,UserManager<ApiUser> userManager) : base(context, mapper,userManager)
        {
            this.context = context;
        }
        public async Task<Service> getServiceFromUser(string id)
        {
            var ser = await context.Services.Where(n => n.ApiUserId == id).FirstOrDefaultAsync();
            return ser;

        }
    }
}
