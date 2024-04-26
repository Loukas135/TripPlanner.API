using Microsoft.AspNetCore.Mvc;

namespace TripPlanner.API.Controllers
{
	[ApiController]
	[Route("api/reservation")]
	public class ReservationController
	{
		[HttpPost]
		public Task<IActionResult> CreateReservation([FromBody] CreateReservationDto createReservationDto)
		{

		}
	}
}
