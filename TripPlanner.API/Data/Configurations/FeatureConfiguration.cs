using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TripPlanner.API.Data.Services;

namespace TripPlanner.API.Data.Configurations
{
	public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
	{
		public void Configure(EntityTypeBuilder<Feature> builder)
		{
			builder.HasData(
				new Feature
				{
					Id = 1,
					Name = "Hotels"
				},
				new Feature
				{
					Id = 2,
					Name = "Tourism Office"
				},
				new Feature
				{
					Id = 3,
					Name = "Car Rental"
				},
				new Feature
				{
					Id = 4,
					Name = "Restaurant"
				}
			);
		}
	}
}
