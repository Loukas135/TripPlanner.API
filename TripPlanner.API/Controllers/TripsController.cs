using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Model.Trip;

namespace TripPlanner.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TripsController : ControllerBase
	{
		[HttpGet]
		public Task<IEnumerable<TripDto>> GetTrips()
		{

		}

		[HttpPost]
		public Task AddTrip([FromBody]CreateTripDto createTripDto)
		{

		}

		[HttpPatch]
		[Route("{id}")]
		public Task UpdateTrip([FromBody] TripDto updateTripDto, int id)
		{

		}

		[HttpDelete]
		[Route("{id}")]
		public Task DeleteTrip(int id)
		{

		}
	}
}
