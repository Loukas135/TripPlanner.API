using System.ComponentModel.DataAnnotations.Schema;

namespace TripPlanner.API.Data
{
	public class Reservation
	{
		public int Id { get; set; }

		[ForeignKey(nameof(ServiceId))]
		public int ServiceId { get; set; }

		[ForeignKey(nameof(RoomId))]
		public int? RoomId { get; set; }

		[ForeignKey(nameof(TripId))]
		public int? TripId { get; set; }

		[ForeignKey(nameof(CarId))]
		public int? CarId { get; set; }

		[ForeignKey(nameof(ApiUserId))]
		public string ApiUserId { get; set; }

		public int Cost { get; set; }

		public DateTime From { get; set; }
		public DateTime To { get; set; }
	}
}
