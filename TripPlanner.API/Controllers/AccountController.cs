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
	}
}
