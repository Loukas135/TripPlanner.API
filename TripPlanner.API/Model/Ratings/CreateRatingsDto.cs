using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripPlanner.API.Model.Ratings
{
    public class CreateRatingsDto
    {
        [Required]
        [Range(0,5)]
        public int Rating { get; set; }
    }
}
