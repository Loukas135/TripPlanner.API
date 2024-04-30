using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Model.Car;
using TripPlanner.API.Model.Room;
using TripPlanner.API.Model.Trip;

namespace TripPlanner.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarsController : ControllerBase
	{
		[HttpGet]
		public Task<IEnumerable<CarDto>> GetCar()
		{

		}

		[HttpPost]
		public Task AddCar([FromBody] CreateCarDto createCarDto)
		{

		}

		[HttpPatch]
		[Route("{id}")]
		public Task UpdateCar([FromBody] CarDto updateCarDto, int id)
		{

		}

		[HttpDelete]
		[Route("{id}")]
		public Task DeleteCar(int id)
		{

		}
	}
}
