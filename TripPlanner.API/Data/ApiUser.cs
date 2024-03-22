using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TripPlanner.API.Data
{
	public class ApiUser : IdentityUser
	{
		[Required]
		public string FirstName;
		[Required]
		public string LastName;
	}
}
