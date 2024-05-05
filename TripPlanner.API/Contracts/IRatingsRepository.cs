using TripPlanner.API.Contracts.Generics;
using TripPlanner.API.Data;

namespace TripPlanner.API.Contracts
{
    public interface IRatingsRepository: IGenericRepository<Ratings>
    {
        public Task<IEnumerable<Ratings>> GetAllInServiceAsync(int serviceId);
        public Task UpdateRating(int serviceId,List<Ratings> ratings);
    }
}
