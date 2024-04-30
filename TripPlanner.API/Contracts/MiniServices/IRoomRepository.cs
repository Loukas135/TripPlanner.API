using TripPlanner.API.Contracts.Generics;
using TripPlanner.API.Data;

namespace TripPlanner.API.Contracts.MiniServices
{
    public interface IRoomRepository : IGenericRepository<Room>
    {
        public Task<Service> getServiceFromUser(string id);

    }
}
