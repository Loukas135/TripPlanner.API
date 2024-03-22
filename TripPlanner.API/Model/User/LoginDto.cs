using System.ComponentModel.DataAnnotations;

namespace TripPlanner.API.Model.User
{
	public class LoginDto
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		[StringLength(15, ErrorMessage = "Invalid", MinimumLength = 6)]
		public string Password { get; set; }
	}
}
