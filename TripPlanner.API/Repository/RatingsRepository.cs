using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TripPlanner.API.Contracts;
using TripPlanner.API.Data;
using TripPlanner.API.Repository.Generics;

namespace TripPlanner.API.Repository
{
    public class RatingsRepository: GenericRepository<Ratings>,IRatingsRepository
    {
        private readonly TripPlannerDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _usermanager;
        private readonly IServiceRepository _serviceRepository;
        public RatingsRepository(TripPlannerDbContext context, IMapper mapper, UserManager<ApiUser> userManager, IServiceRepository serviceRepository) : base(context, mapper, userManager)
        {
            _context = context;
            _mapper = mapper;
            _usermanager = userManager;
            _serviceRepository = serviceRepository;

        }

        public async Task<IEnumerable<Ratings>> GetAllInServiceAsync(int serviceId)
        {
            var rates = await _context.Ratings.Where(r => r.ServiceId == serviceId).ToListAsync();
            return rates;
        }

       /* public Task UpdateRating(int serviceId, List<Ratings> ratings)
        {
            throw new NotImplementedException();
        }*/

        public async Task UpdateRating(int serviceId, List<Ratings> ratings)
        {
           var service= await _serviceRepository.GetAsync(serviceId);
            int overall = 0;
           foreach(var rate in ratings)
            {
                overall += rate.Rating;
            }
            overall /= ratings.Count;
            service.Overall_Rating = overall;
            await _serviceRepository.UpdateAsync(service);
        }
    }
}
