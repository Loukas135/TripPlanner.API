﻿using System.ComponentModel.DataAnnotations.Schema;

namespace TripPlanner.API.Data
{
	public class Trip
	{
		public int Id { get; set; }
		public DateTime From { get; set; }
		public DateTime To { get; set; }
		public string Description { get; set; }
		public int Days { get; set; }
		public int Tickets { get; set; }
		public float Price { get; set; }
		[ForeignKey(nameof(ServiceId))]
		public int ServiceId { get; set; }
	}
}
