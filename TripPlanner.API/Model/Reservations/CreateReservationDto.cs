using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace TripPlanner.API.Model.Reservations
{
	public class CreateReservationDto
	{
		[ForeignKey(nameof(ServiceId))]
		public int ServiceId { get; set; }

		[AllowNull]
		[ForeignKey(nameof(RoomId))]
		
		public int? RoomId { get; set; }
		[AllowNull]
		[ForeignKey(nameof(TripId))]
		public int? TripId { get; set; }
		[AllowNull]
		[ForeignKey(nameof(CarId))]
		public int? CarId { get; set; }

		public DateTime From { get; set; }
		public DateTime To { get; set; }
	}
}
