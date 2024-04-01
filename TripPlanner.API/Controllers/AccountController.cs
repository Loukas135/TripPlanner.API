using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Contracts;
using TripPlanner.API.Data;
using TripPlanner.API.Data.Services;
using TripPlanner.API.Model.User;
using TripPlanner.API.Repository;

namespace TripPlanner.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		private readonly IAuthManager _authManager;
		private readonly ILogger<AccountController> _logger;
		private readonly UserManager<ApiUser> _userManager;
		public AccountController(IAuthManager authManager, ILogger<AccountController> logger, UserManager<ApiUser> userManager)
        {
			this._authManager = authManager;
			this._logger = logger;
			_userManager = userManager;
		}
		[HttpPost]
		[Route("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Login([FromBody]LoginDto creds)
		{
			var response = await _authManager.Login(creds);
			if (response == null)
			{
				return Unauthorized();
			}
			return Ok(response);
		}
		[HttpPost]
		[Route("register")]
        public async Task<ActionResult> Register([FromBody] ApiUserDto user)
		{
			var response = await _authManager.Register(user);
			if (response.Any())
			{
				foreach(var error in response)
				{
                    ModelState.AddModelError(error.Code, error.Description);
                }
				return BadRequest(ModelState);
			}
			return Ok(user);
		}

		[HttpPost]
		[Route("RegisterServiceOwner")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult> RegisterServiceOwner([FromBody] ServiceOwnerDto serviceOwnerDto)
		{
			var response = await _authManager.RegisterServiceOwner(serviceOwnerDto);
			if (response.Any())
			{
				foreach(var error in response)
				{
					ModelState.AddModelError(error.Code, error.Description);
				}
				return BadRequest(ModelState);
			}
			return Ok(serviceOwnerDto);
		}

		[HttpPost]
		[Route("RefreshToken")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult> RefreshToken([FromBody]AuthResponseDto request)
		{
			var response = await _authManager.VerifyRefreshToken(request);
			if (response is null)
			{
				return Unauthorized();
			}
			return Ok(response);
		}
        [HttpPost]
        [Route("Logout")]
        [Authorize]
        public async Task<ActionResult> LogOut()
        {
            var user = await GetCurrentUser();
            await _authManager.DeleteToken(user);
            return Ok();
        }
        private async Task<ApiUser> GetCurrentUser()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (user is null)
            {
                return null;
            }
            return user;
        }
    }
}
