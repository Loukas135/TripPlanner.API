namespace TripPlanner.API.Model.Car
{
	public class CreateCarDto
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public float PricePerMonth { get; set; }
		public int Quantity { get; set; }
	}
}
