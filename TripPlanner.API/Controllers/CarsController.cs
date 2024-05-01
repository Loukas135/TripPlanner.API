using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Contracts.MiniServices;
using TripPlanner.API.Data;
using TripPlanner.API.Model.Car;
using TripPlanner.API.Model.Room;
using TripPlanner.API.Model.Trip;

namespace TripPlanner.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarsController : ControllerBase
	{
		private readonly ICarRepository _car;
		private readonly IMapper _mapper;
		private readonly UserManager<ApiUser> _userManager;
		public CarsController(ICarRepository car,IMapper mapper,UserManager<ApiUser>userManager)
		{
			_car = car;
			_mapper = mapper;
			_userManager = userManager;
		}
		[HttpGet]
		public async Task<ActionResult> GetCar(int id)
		{
			if (id == null)
			{
				return BadRequest();
			}
			var car = await _car.GetAsync(id);
			return Ok(car);
		}
		[Authorize(Roles = "CarRental")]
		[HttpPost]
		public async Task<ActionResult> AddCar([FromBody] CreateCarDto createCarDto)
		{
			var car = _mapper.Map<Car>(createCarDto);
			var user = await GetCurrentUser();
			var service_id = _car.getServiceFromUser(user.Id.ToString()).Id;
			car.ServiceId = service_id;
			await _car.AddAsync(car);
			return CreatedAtAction("GetCar", new { id = car.Id }, car);
		}

		[HttpPatch]
		[Route("{id}")]
		public async Task<ActionResult> UpdateCar([FromBody] Car car, int id)
		{
			if (car.Id != id)
			{
				return BadRequest();
			}
			await _car.UpdateAsync(car);
			return Ok(car);
		}

		[HttpDelete]
		[Route("{id}")]
		public async Task<ActionResult> DeleteCar(int id)
		{
			if (id == null)
			{
				return BadRequest();
			}
			await _car.DeleteAsync(id);
			return NoContent();
		}
		private async Task<ApiUser> GetCurrentUser()
		{
			var user = await _userManager.GetUserAsync(HttpContext.User);
			if(user is null)
			{
				return null;
			}
			return user;
		}
	}
}
