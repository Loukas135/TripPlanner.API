using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TripPlanner.API.Model.User
{
	public class ApiUserDto : LoginDto
	{
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		/*public string Email;
		[Required]
		[StringLength(16, ErrorMessage = "Your Password is limited from 6 to 16 characters.", MinimumLength = 6)]
		public string Password;
		[AllowNull]
		public string PhoneNumber;*/

	}
}
