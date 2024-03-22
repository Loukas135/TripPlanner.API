using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TripPlanner.API.Data.Configurations;

namespace TripPlanner.API.Data
{
	public class TripPlannerDbContext : IdentityDbContext<ApiUser>
	{
        public TripPlannerDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfigurations());
        }
    }
}
