using Microsoft.AspNetCore.Identity;
using TripPlanner.API.Data;
using TripPlanner.API.Data.Services;
using TripPlanner.API.Model.User;

namespace TripPlanner.API.Contracts
{
    public interface IAuthManager
	{
		Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
		Task<IEnumerable<IdentityError>> RegisterServiceOwner(ServiceOwnerDto serviceOwnerDto);
		Task<AuthResponseDto> Login(LoginDto loginDto);
		Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request);
		public  Task DeleteToken(ApiUser user);
       
	}
}
