namespace TripPlanner.API.Data
{
    public class Governorate
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public virtual IList<Service> Services{ get; set; }
		
	}
}
