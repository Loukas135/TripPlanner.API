using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TripPlanner.API.Contracts;
using TripPlanner.API.Data;
using TripPlanner.API.Data.Services;
using TripPlanner.API.Model.User;


namespace TripPlanner.API.Repository
{
	public class AuthManager : IAuthManager
	{
		private readonly UserManager<ApiUser> _userManager;
		private readonly IMapper _mapper;
		private readonly IConfiguration _configuration;
		private ApiUser _user;
		public AuthManager(UserManager<ApiUser> userManager, IMapper mapper, IConfiguration configuration)
        {
			this._userManager = userManager;
			this._mapper = mapper;
			this._configuration = configuration;
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
                UserName =_user.UserName
				
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

		public Task<IEnumerable<IdentityError>> RegisterServiceOwner(ServiceOwnerDto serviceOwnerDto)
		{
			throw new NotImplementedException();
		}
	}
}
