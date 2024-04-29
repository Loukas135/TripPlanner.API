using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

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

        [AllowNull]
        [ForeignKey(nameof(ApiUserId))]
        public string? ApiUserId { get; set; }

        [Required]
		[ForeignKey(nameof(ServiceTypeId))]
        [Range(1, 4)]
        public int ServiceTypeId { get; set; }

		
    }
}
