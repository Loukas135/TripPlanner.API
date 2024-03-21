using Microsoft.EntityFrameworkCore;

namespace TripPlanner.API.Data
{
	public class TripPlannerDbContext : DbContext
	{
        public TripPlannerDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
