using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TripPlanner.API.Data.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasData(
                new Room
                {
                    Id=1,
                    Description="room no 1",
                    NumberOfPeople=3,
                    PricePerNight=0,
                    RoomCategoryId=1,
                    ServiceId=1,
                    Quantity=1000
            }
                );
        }
    }
}
