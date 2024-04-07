using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace TripPlanner.API.Model.Services
{
	public class ServiceDto
	{
		[Required]
		public string ServiceUserName { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		public string ServiceType { get; set; }

		/**/

		[Required]
		public string Name { get; set; }
		[Required]
		public string Address { get; set; }
		[Required]
		public string Description { get; set; }

		[Required]
		[ForeignKey(nameof(GovernorateId))]
		[Range(1, 14)]
		public int GovernorateId { get; set; }

		[Required]
		[ForeignKey(nameof(FeatureId))]
		[Range(1, 4)]
		public int FeatureId { get; set; }

		[AllowNull]
		[ForeignKey(nameof(UserId))]
		public string? UserId { get; set; }
	}
}
