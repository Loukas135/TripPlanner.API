using Microsoft.AspNetCore.Identity;
using TripPlanner.API.Data;
using TripPlanner.API.Data.Services;
using TripPlanner.API.Model.Response;
using TripPlanner.API.Model.Services;
using TripPlanner.API.Model.User;

namespace TripPlanner.API.Contracts
{
    public interface IAuthManager
	{
		public Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
		//public Task<RegisterOwnerResponseDto> RegisterServiceOwner(ServiceOwnerDto serviceOwnerDto);
		public Task<IEnumerable<IdentityError>> RegisterServiceOwner(ServiceOwnerDto serviceOwnerDto);
		public Task<AuthResponseDto> Login(LoginDto loginDto);
		public Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request);
		public Task DeleteToken(ApiUser user);
       
	}
}
