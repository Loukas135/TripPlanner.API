using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using TripPlanner.API.Contracts;
using TripPlanner.API.Data;
using TripPlanner.API.Model.User;

namespace TripPlanner.API.Repository
{
	public class AuthManager : IAuthManager
	{
		private readonly UserManager<ApiUser> _userManager;
		private readonly IMapper _mapper;
		private readonly IConfiguration _configuration;
		public AuthManager(UserManager<ApiUser> userManager, IMapper mapper, IConfiguration configuration)
        {
			this._userManager = userManager;
			this._mapper = mapper;
			this._configuration = configuration;
		}

        public Task<bool> Login(LoginDto loginDto)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Logout()
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto)
		{
			throw new NotImplementedException();
		}
	}
}
