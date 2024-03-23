using AutoMapper;
using TripPlanner.API.Data;
using TripPlanner.API.Model.User;

namespace TripPlanner.API.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<ApiUser, ApiUserDto>().ReverseMap();
        }
    }
}
