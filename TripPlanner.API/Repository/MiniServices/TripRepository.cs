﻿using TripPlanner.API.Contracts.MiniServices;
using TripPlanner.API.Data;
using TripPlanner.API.Repository.Generics;

namespace TripPlanner.API.Repository.MiniServices
{
    public class TripRepository : MiniGenericRepository<Trip>, ITripRepository
    {
    }
}
