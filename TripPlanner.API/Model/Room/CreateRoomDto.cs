namespace TripPlanner.API.Model.Room
{
	public class CreateRoomDto
	{
		public string Description { get; set; }
		public int NumberOfPeople { get; set; }
		public float PricePerNight { get; set; }
		public int Quantity { get; set; }
	}
}
