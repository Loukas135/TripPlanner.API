using Microsoft.AspNetCore.Identity;
using TripPlanner.API.Model.User;

namespace TripPlanner.API.Contracts
{
	public interface IAuthManager
	{
		Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
		Task<AuthResponseDto> Login(LoginDto loginDto);
		Task<bool> Logout();
	}
}
