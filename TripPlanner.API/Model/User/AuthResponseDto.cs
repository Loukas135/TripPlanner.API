namespace TripPlanner.API.Model.User
{
	public class AuthResponseDto
	{
		public string UserName { get; set; }
		public string Token { get; set; }
		public string RefreshToken { get; set; }
	}
}
