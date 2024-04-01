namespace TripPlanner.API.Data
{
	public class CarCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public IList<Car> Cars { get; set; }
	}
}
