using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TripPlanner.API.Model.User
{
	public class ApiUserDto
	{
		[Required]
		public string FirstName;
		[Required]
		public string LastName;
		[Required]
		public string Email;
		[Required]
		public bool IsEmailConfirmed;
		[Required]
		[StringLength(16, ErrorMessage = "Your Password is limited from {2} to {1} characters.", MinimumLength = 6)]
		public string Password;
		[AllowNull]
		public string PhoneNumber;

	}
}
