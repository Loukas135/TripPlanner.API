namespace TripPlanner.API.Data
{
	public class RoomCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public IList<Room> Rooms { get; set; }
	}
}
