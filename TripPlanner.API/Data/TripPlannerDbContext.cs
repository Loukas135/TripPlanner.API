using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TripPlanner.API.Data
{
	public class TripPlannerDbContext : IdentityDbContext<ApiUser>
	{
        public TripPlannerDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
