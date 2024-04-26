using System.ComponentModel.DataAnnotations.Schema;

namespace TripPlanner.API.Data
{
	public class Room
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public int NumberOfPeople { get; set; }
		public float PricePerNight { get; set; }
		[ForeignKey(nameof(RoomCategoryId))]
		public int RoomCategoryId { get; set; }
		[ForeignKey(nameof(ServiceId))]
		public int ServiceId { get; set; }
		public Service Service { get; set; }
		public int Quantity { get; set; }
	}
}
