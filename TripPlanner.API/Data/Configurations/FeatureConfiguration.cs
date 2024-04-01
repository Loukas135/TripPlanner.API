using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TripPlanner.API.Data.Services;

namespace TripPlanner.API.Data.Configurations
{
	public class FeatureConfiguration : IEntityTypeConfiguration<ServiceType>
	{
		public void Configure(EntityTypeBuilder<ServiceType> builder)
		{
			builder.HasData(
				new ServiceType
				{
					Id = 1,
					Name = "Hotels"
				},
				new ServiceType
				{
					Id = 2,
					Name = "Tourism Office"
				},
				new ServiceType
				{
					Id = 3,
					Name = "Car Rental"
				},
				new ServiceType
				{
					Id = 4,
					Name = "Restaurant"
				}
			);
		}
	}
}
