using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Data;
using TripPlanner.API.Data.Services;

namespace TripPlanner.API.Contracts
{
    public interface IServiceRepository
    {
       public  Task<Service> GetAsync(int? id);
        public Task<Service> CreateAsync(Service service);
        public Task<List<Service>> SearchByName(string name);
       public Task<List<Service>> FilterByType(string type);
       //public Task CreateServiceAsync(ServiceRegisterDto serviceRegisterDto, string userName);

	}
}
