using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TripPlanner.API.Data.Configurations
{
	public class CarCategoryConfiguration : IEntityTypeConfiguration<CarCategory>
	{
		public void Configure(EntityTypeBuilder<CarCategory> builder)
		{
			builder.HasData(
				new CarCategory
				{
					Id = 1,
					Name = "High"
				},
				new CarCategory
				{
					Id = 2,
					Name = "Medium"
				},
				new CarCategory
				{
					Id = 3,
					Name = "Low"
				}
			);
		}
	}
}
