using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TripPlanner.API.Contracts;
using TripPlanner.API.Data;
using TripPlanner.API.Model.Reservations;
using TripPlanner.API.Repository.Generics;

namespace TripPlanner.API.Repository
{
    public class ReservationRepository : GenericRepository<Reservation>, IReservationRepository
	{
		private readonly IMapper mapper;
		private readonly TripPlannerDbContext dbContext;
		private readonly UserManager<ApiUser> userManager;

        public ReservationRepository(TripPlannerDbContext context, IMapper mapper, UserManager<ApiUser> userManager) : base(context, mapper, userManager)
        {
        }

        public async Task<int> AddReservationAsync(CreateReservationDto createReservationDto, string userId)
		{
			var reservation = mapper.Map<Reservation>(createReservationDto);
			reservation.ApiUserId = userId;
			dbContext.Reservations.Add(reservation);
			await dbContext.SaveChangesAsync();
			return reservation.Id;
		}

		public async Task DeleteReservationAsync(int id)
		{
			Reservation reservation = await GetAsync(id);
			ApiUser? user = await userManager.FindByIdAsync(reservation.ApiUserId);
			user.wallet += reservation.Cost;
			await DeleteAsync(id);
			await userManager.UpdateAsync(user);
		}
	}
}
