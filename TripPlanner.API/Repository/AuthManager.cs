using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using TripPlanner.API.Contracts;
using TripPlanner.API.Data;
using TripPlanner.API.Data.Services;
using TripPlanner.API.Model.Response;
using TripPlanner.API.Model.Services;
using TripPlanner.API.Model.User;


namespace TripPlanner.API.Repository
{
    public class AuthManager : IAuthManager
	{
		private readonly UserManager<ApiUser> _userManager;
		private readonly IMapper _mapper;
		private readonly IConfiguration _configuration;
		private ApiUser _user;
		private readonly TripPlannerDbContext _context;
		private readonly IServiceRepository _serviceRepository;
		private readonly string _loginprovidor = "TripPlannerLoginProvidor";
        private readonly string _refresh= "RefreshToken";

		public AuthManager(UserManager<ApiUser> userManager, IMapper mapper, IConfiguration configuration, TripPlannerDbContext context, IServiceRepository serviceRepository)
        {
			this._userManager = userManager;
			this._mapper = mapper;
			this._configuration = configuration;
			_context = context;
			this._serviceRepository = serviceRepository;
		}

        public async Task<AuthResponseDto> Login(LoginDto loginDto)
		{
            _user = await _userManager.FindByEmailAsync(loginDto.Email);
			if(_user == null)
			{
				return null;
			}
			var isValid = await _userManager.CheckPasswordAsync(_user, loginDto.Password);
            if (!isValid)
            {
                return null;
            }

			var token = await GenerateToken(_user);

			return new AuthResponseDto {
                Token = token,
                UserName = _user.UserName
				
			};

        }
		private async Task<string>GenerateToken(ApiUser user)
		{
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]));
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
			var roles =await _userManager.GetRolesAsync(user);
			var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x));
			var userClaims = await _userManager.GetClaimsAsync(user);
			var claimList = new List<Claim>
			{
				new Claim(JwtRegisteredClaimNames.Sub, user.Id),
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
				new Claim(JwtRegisteredClaimNames.Email, user.Email),
				new Claim("id",user.Id)
			}.Union(userClaims).Union(roleClaims);
			var token = new JwtSecurityToken(
				issuer: _configuration["JwtSettings:Issuer"],
				audience: _configuration["JwtSettings:Audience"],
				claims: claimList,
				expires: DateTime.Now.AddMinutes(Convert.ToInt32(_configuration["JwtSettings:DurationInMinutes"])),
				signingCredentials: credentials
				);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

		public Task<bool> Logout()
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto)
		{
			_user = _mapper.Map<ApiUser>(userDto);
			_user.UserName = _user.Email;
			var check = await _userManager.CreateAsync(_user, userDto.Password);
			if (check.Succeeded)
			{
				 await _userManager.AddToRoleAsync(_user, "User");
			}
			return check.Errors;
		}

		public async Task<IEnumerable<IdentityError>> RegisterServiceOwner(ServiceOwnerDto serviceOwnerDto)
		{
			_user = _mapper.Map<ApiUser>(serviceOwnerDto);
			_user.UserName = _user.UserName;

			var check = await _userManager.CreateAsync(_user, serviceOwnerDto.Password);
			
			if (check.Succeeded) {
				await _userManager.AddToRoleAsync(_user, serviceOwnerDto.ServiceType);
			}
			return check.Errors;
		}
		
        public async Task<string> CreateRefreshToken()
        {
            await _userManager.RemoveAuthenticationTokenAsync(_user, _loginprovidor, _refresh);
            var NewToken = await _userManager.GenerateUserTokenAsync(_user, _loginprovidor, _refresh);
            var res = await _userManager.SetAuthenticationTokenAsync(_user, _loginprovidor, _refresh, NewToken);
            return NewToken;

        }

        public async Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request)
        {
            var jwtSecurityHandler = new JwtSecurityTokenHandler();
            var tokenContent = jwtSecurityHandler.ReadJwtToken(request.Token);
            var username = tokenContent.Claims.ToList().FirstOrDefault(q => q.Type == JwtRegisteredClaimNames.Sub)?.Value;
            _user = await _userManager.FindByIdAsync(username);
            if (_user is null)
            {
                return null;
            }
            var isValidRefreshToken = await _userManager.VerifyUserTokenAsync(_user, _loginprovidor, _refresh, request.RefreshToken);
            if (isValidRefreshToken)
            {
                var token = await GenerateToken(_user);
                return new AuthResponseDto
                {
                    Token = token,
                    UserName = _user.UserName,
                    RefreshToken = await CreateRefreshToken()
                };
            }
            await _userManager.UpdateSecurityStampAsync(_user);
            return null;
        }
        public async Task DeleteToken(ApiUser user)
        {
            _user = user;
            await _userManager.RemoveAuthenticationTokenAsync(_user, _loginprovidor, _refresh);
            await _userManager.UpdateSecurityStampAsync(_user);

        }
	}
}
