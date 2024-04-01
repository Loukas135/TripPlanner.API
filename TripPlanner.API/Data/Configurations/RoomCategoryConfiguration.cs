using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TripPlanner.API.Data.Configurations
{
	public class RoomCategoryConfiguration : IEntityTypeConfiguration<RoomCategory>
	{
		public void Configure(EntityTypeBuilder<RoomCategory> builder)
		{
			builder.HasData(
				new RoomCategory
				{
					Id = 1,
					Name = "First Class"
				},
				new RoomCategory
				{
					Id = 2,
					Name = "Second Class"
				},
				new RoomCategory
				{
					Id = 3,
					Name = "Third Class"
				}
			);
		}
	}
}
