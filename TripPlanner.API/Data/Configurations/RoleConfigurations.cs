using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TripPlanner.API.Data.Configurations
{
	public class RoleConfigurations : IEntityTypeConfiguration<IdentityRole>
	{
		public void Configure(EntityTypeBuilder<IdentityRole> builder)
		{
			builder.HasData(
				new IdentityRole
				{
					Name = "User",
					NormalizedName = "USER"
				},
				new IdentityRole
				{
					Name = "Administrator",
					NormalizedName = "ADMINISTRATOR"
				},
				new IdentityRole
				{
					Name = "HotelOwner",
					NormalizedName = "HOTELOWNER"
				},
				new IdentityRole
				{
					Name = "CarRental",
					NormalizedName = "CARRENTAL"
				},
				new IdentityRole
				{
					Name = "TravelOffice",
					NormalizedName = "TRAVELOFFICE"
				},
				new IdentityRole
				{
					Name = "RestaurantOwner",
					NormalizedName = "RESTAURANTOWNER"
				}
			);
		}
	}
}
