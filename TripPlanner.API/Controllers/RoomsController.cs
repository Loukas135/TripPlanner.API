using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Contracts.MiniServices;
using TripPlanner.API.Data;
using TripPlanner.API.Model.Room;
using TripPlanner.API.Model.Trip;
using TripPlanner.API.Repository.MiniServices;

namespace TripPlanner.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoomsController : ControllerBase
	{
		private readonly IRoomRepository _room;
		private readonly IMapper _mapper;
		private readonly UserManager<ApiUser> _userManager;
		public RoomsController(IRoomRepository room, IMapper mapper,UserManager<ApiUser>userManager)
		{
			_room = room;
			_mapper = mapper;
			_userManager = userManager;
		}
		[HttpGet]
		public async Task<ActionResult<RoomDto>> GetRoom(int id)
		{
			var rooms = await _room.GetAsync(id);
			return Ok(rooms);
		}
		[Authorize(Roles ="HotelOwner")]
		[HttpPost]
		public async Task<ActionResult> AddRoom([FromBody] CreateRoomDto createRoomDto)
		{
			var room = _mapper.Map<Room>(createRoomDto);
			var user= await GetCurrentUser();
			var user_id = user.Id.ToString();
			var service_id= _room.getServiceFromUser(user_id).Id;
			room.ServiceId = service_id;
			await _room.AddAsync(room);
			return CreatedAtAction("GetRoom",new { id = room.Id },room);
		}
		[HttpPatch]
		[Route("{id}")]
		public async Task<ActionResult> UpdateRoom([FromBody] RoomDto updateRoomDto, int id)
		{
			var room=_mapper.Map<Room>(updateRoomDto);
			await _room.UpdateAsync(room);
			return Ok();
		}

		[HttpDelete]
		[Route("{id}")]
		public async Task<ActionResult> DeleteRoom(int id)
		{
			await _room.DeleteAsync(id);
			return NoContent();
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
