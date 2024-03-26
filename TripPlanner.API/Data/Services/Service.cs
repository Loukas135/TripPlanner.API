using System.ComponentModel.DataAnnotations.Schema;

namespace TripPlanner.API.Data.Services
{
	public class Service
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Description { get; set; }
		[ForeignKey(nameof(GovernorateId))]
		public int GovernorateId { get; set; }
		public Governorate Governorate { get; set; }
		[ForeignKey(nameof(ApiUserId))]
		public int ApiUserId { get; set; }
		public ApiUser ApiUser{ get; set; }

	}
}
