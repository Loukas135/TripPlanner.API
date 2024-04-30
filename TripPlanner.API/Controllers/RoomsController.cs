using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Model.Room;
using TripPlanner.API.Model.Trip;

namespace TripPlanner.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoomsController : ControllerBase
	{
		[HttpGet]
		public Task<IEnumerable<RoomDto>> GetRoom()
		{

		}

		[HttpPost]
		public Task AddRoom([FromBody] CreateRoomDto createRoomDto)
		{

		}

		[HttpPatch]
		[Route("{id}")]
		public Task UpdateRoom([FromBody] RoomDto updateRoomDto, int id)
		{

		}

		[HttpDelete]
		[Route("{id}")]
		public Task DeleteRoom(int id)
		{

		}
	}
}
