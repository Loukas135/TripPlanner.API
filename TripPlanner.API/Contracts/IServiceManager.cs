using TripPlanner.API.Data;

namespace TripPlanner.API.Contracts
{
    public interface IServiceManager:IGenericRepository<Service>
    {
       public Task<List<Service>>SearchByName(string name);
        public Task<List<Service>> FilterByType(string type);

    }
}
