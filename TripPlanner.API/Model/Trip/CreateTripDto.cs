namespace TripPlanner.API.Model.Trip
{
	public class CreateTripDto
	{
		public DateTime From { get; set; }
		public DateTime To { get; set; }
		public string Description { get; set; }
		public int Days { get; set; }
		public int Tickets { get; set; }
		public float Price { get; set; }
	}
}
