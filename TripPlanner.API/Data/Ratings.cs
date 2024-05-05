
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripPlanner.API.Data
{
    public class Ratings
    {
        
        public int Id { get; set; }
        [ForeignKey(nameof(ApiUserId))]
        [Required]
        public string ApiUserId { get; set; }
        [ForeignKey(nameof(ServiceId))]
        [Required]
        public int ServiceId { get; set; }
        [Required]
        [Range(0,5)]
        public int Rating { get; set; }

    }
}
