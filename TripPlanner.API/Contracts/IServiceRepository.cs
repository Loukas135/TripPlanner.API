﻿using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Data;
using TripPlanner.API.Data.Services;

namespace TripPlanner.API.Contracts
{
    public interface IServiceRepository : IGenericRepository<Service>
    {
       public Task<List<Service>> SearchByName(string name);
       public Task<List<Service>> FilterByType(string type);
    }
}
