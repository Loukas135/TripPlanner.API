using TripPlanner.API.Data.Services;

namespace TripPlanner.API.Data
{
	public class Governorate
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public virtual IList<Hotel> Hotels { get; set; }
		public virtual IList<Restaurant> Restaurants { get; set; }
		public virtual IList<CarRental> CarRentals { get; set; }
		public virtual IList<TourismOffice> TourismOffices { get; set; }
	}
}
