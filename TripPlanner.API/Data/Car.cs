using System.ComponentModel.DataAnnotations.Schema;

namespace TripPlanner.API.Data
{
	public class Car
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public float PricePerMonth { get; set; }
		[ForeignKey(nameof(CarCategoryId))]
		public int CarCategoryId { get; set; }
		[ForeignKey(nameof(ServiceId))]
		public int ServiceId { get; set; }

	}
}
