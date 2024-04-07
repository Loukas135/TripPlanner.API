﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TripPlanner.API.Data.Configurations;

namespace TripPlanner.API.Data
{
    public class TripPlannerDbContext : IdentityDbContext<ApiUser>
	{
        public TripPlannerDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Service> Services { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfigurations());
            modelBuilder.ApplyConfiguration(new ServiceConfiguration());
            modelBuilder.ApplyConfiguration(new CarCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new RoomCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new GovernorateConfiguration());
        }
    }
}
