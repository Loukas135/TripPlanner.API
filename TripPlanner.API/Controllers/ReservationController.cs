using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Contracts;
using TripPlanner.API.Data;
using TripPlanner.API.Model.Reservations;

namespace TripPlanner.API.Controllers
{
	[ApiController]
	[Route("api/reservation")]
	public class ReservationController(IReservationRepository reservationRepository, 
		UserManager<ApiUser> userManager) : ControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> GetById(int id)
		{
			var reservation = await reservationRepository.GetAsync(id);
			return Ok(reservation);
		}

		[HttpPost]
		[Authorize(Roles = "User")]
		public async Task<IActionResult> CreateReservation([FromBody] CreateReservationDto createReservationDto)
		{
			var user = await userManager.GetUserAsync(HttpContext.User);
			if(user == null)
			{
				return BadRequest();
			}
			int id =  await reservationRepository.AddReservationAsync(createReservationDto, user.Id);
			return CreatedAtAction(nameof(GetById), new { id }, null);
		}

		[HttpPost]
		[Authorize(Roles = "User")]
		public async Task<IActionResult> DeleteReservation(int id)
		{
			await reservationRepository.DeleteReservationAsync(id);
			return Ok();
		}
	}
}
