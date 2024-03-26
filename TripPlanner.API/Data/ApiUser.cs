using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace TripPlanner.API.Data
{
	public class ApiUser : IdentityUser
	{
		[Required]
		public string FirstName { get; set; }
		
		public string? LastName { get; set; }
	}
}
