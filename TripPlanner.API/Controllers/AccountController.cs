using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Contracts;
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
		public AccountController(IAuthManager authManager, ILogger<AccountController> logger)
        {
			this._authManager = authManager;
			this._logger = logger;
		}
		[HttpPost]
		[Route("login")]
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
	}
}
