using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using TripPlanner.API.Data.Configurations;

namespace TripPlanner.API.Data
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }


        [ForeignKey(nameof(GovernorateId))]
        public int GovernorateId { get; set; }
        [AllowNull]
        public Governorate? Governorate { get; set; }

        [AllowNull]
        [ForeignKey(nameof(ApiUserId))]
        public string? ApiUserId { get; set; }
        [AllowNull]
        public ApiUser? ApiUser { get; set; }


		[ForeignKey(nameof(ServiceTypeId))]
		public int ServiceTypeId { get; set; }
        [AllowNull]
        public ServiceType? ServiceType { get; set; }
        [AllowNull]
        [Range(0, 5)]
        public int? Overall_Rating { get; set; } = null;
    }
}
