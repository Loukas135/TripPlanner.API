using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripPlanner.API.Data.Services
{
    public class ServiceRegisterDto
	{
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
		[Required]
		[ForeignKey(nameof(UserId))]
		public int UserId { get; set; }
    }
}
