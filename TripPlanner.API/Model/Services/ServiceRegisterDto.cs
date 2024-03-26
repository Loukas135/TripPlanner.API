using System.ComponentModel.DataAnnotations.Schema;

namespace TripPlanner.API.Data.Services
{
    public class ServiceRegisterDto
	{
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string GovernorateName { get; set; }
        public string ServiceType { get; set; }
    }
}
