using Microsoft.AspNetCore.Identity;
using TripPlanner.API.Data.Services;
using TripPlanner.API.Model.User;

namespace TripPlanner.API.Contracts
{
    public interface IAuthManager
	{
		Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
		Task<IEnumerable<IdentityError>> RegisterHotel(ServiceRegisterDto serviceRegisterDto);
		Task<AuthResponseDto> Login(LoginDto loginDto);
		Task<bool> Logout();
	}
}
