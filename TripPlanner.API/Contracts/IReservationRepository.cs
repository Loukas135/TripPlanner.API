using TripPlanner.API.Data;
using TripPlanner.API.Model.Reservations;

namespace TripPlanner.API.Contracts
{
	public interface IReservationRepository : IGenericRepository<Reservation>
	{
		public Task<int> AddReservationAsync(CreateReservationDto createReservationDto, string userId);

		public Task DeleteReservationAsync(int id);
	}
}
