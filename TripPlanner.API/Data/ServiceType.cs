namespace TripPlanner.API.Data.Configurations
{
	public class ServiceType
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public IList<Service> Services { get; set; }
	}
}
