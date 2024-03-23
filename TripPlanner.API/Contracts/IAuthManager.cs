using Microsoft.AspNetCore.Identity;
using TripPlanner.API.Model.User;
using TripPlanner.API.Model.User.CarRental;
using TripPlanner.API.Model.User.Hotel;
using TripPlanner.API.Model.User.Restaurant;
using TripPlanner.API.Model.User.TourismOffice;

namespace TripPlanner.API.Contracts
{
    public interface IAuthManager
	{
		Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
		Task<IEnumerable<IdentityError>> RegisterHotel(RegisterHotelDto hotelOwnerDto);
		Task<IEnumerable<IdentityError>> RegisterCarRental(RegisterCarRentalDto carRentalDto);
		Task<IEnumerable<IdentityError>> RegisterRestaurant(RegisterRestaurantDto restaurantDto);
		Task<IEnumerable<IdentityError>> RegisterTourismOffice(RegisterTourismOfficeDto registerTourismOfficeDto);
		Task<AuthResponseDto> Login(LoginDto loginDto);
		Task<bool> Logout();
	}
}
