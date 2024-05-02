using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.Runtime.CompilerServices;
using TripPlanner.API.Contracts.MiniServices;
using TripPlanner.API.Data;
using TripPlanner.API.Model.Trip;

namespace TripPlanner.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TripsController(ITripRepository tripRepository, IMapper mapper, UserManager<ApiUser> userManager) : ControllerBase
	{
		[HttpGet]
		public async Task<ActionResult<IEnumerable<TripDto>>> GetTrips()
		{
			var trips = await tripRepository.GetAllAsync();
			var tripDtos = mapper.Map<TripDto>(trips);
			return Ok(tripDtos);
		}

		[HttpGet]
		[Route("{id}")]
		public async Task<ActionResult<TripDto>> GetTrip([FromRoute] int id)
		{
			var trip = await tripRepository.GetAsync(id);
			var tripDto = mapper.Map<TripDto>(trip);
			return Ok(tripDto);
		}

		[HttpPost]
		public async Task<IActionResult> AddTrip([FromBody]CreateTripDto createTripDto)
		{
			var trip = mapper.Map<Trip>(createTripDto);
			
			var user = GetCurrentUser();
			var userId = user.Id.ToString();

			var service_id = tripRepository.getServiceFromUser(userId).Id;
			trip.ServiceId = service_id;

			await tripRepository.AddAsync(trip);
			return CreatedAtAction(nameof(GetTrip), trip.Id, null);
		}

		[HttpPatch]
		[Route("{id}")]
		public async Task<IActionResult> UpdateTrip([FromBody] TripDto updateTripDto, int id)
		{
			var trip = mapper.Map<Trip>(updateTripDto);
			if(id == trip.Id)
			{
				await tripRepository.UpdateAsync(trip);
				return Ok();
			}
			return NotFound();
		}

		[HttpDelete]
		[Route("{id}")]
		public async Task<IActionResult> DeleteTrip(int id)
		{
			await tripRepository.DeleteAsync(id);
			return NoContent();
		}

		private async Task<ApiUser> GetCurrentUser()
		{
			var user = await userManager.GetUserAsync(HttpContext.User);

			if (user is null)
			{
				return null;
			}
			return user;
		}
	}
}
