using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TripPlanner.API.Data;
using TripPlanner.API.Data.Services;


namespace TripPlanner.API.Model.User
{
    public class ServiceOwnerDto
    {
        [Required]
        public string ServiceUserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ServiceType { get; set; }
    }
}
