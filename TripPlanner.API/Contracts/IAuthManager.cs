using Microsoft.AspNetCore.Identity;
using TripPlanner.API.Model.User;

namespace TripPlanner.API.Contracts
{
	public interface IAuthManager
	{
		Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
		Task<bool> Login(LoginDto loginDto);
		Task<bool> Logout();
	}
}
