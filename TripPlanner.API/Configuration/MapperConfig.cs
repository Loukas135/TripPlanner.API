using AutoMapper;
using TripPlanner.API.Data;
using TripPlanner.API.Data.Services;
using TripPlanner.API.Model.Reservations;
using TripPlanner.API.Model.User;

namespace TripPlanner.API.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<ApiUser, ApiUserDto>().ReverseMap();
            CreateMap<ApiUser, ServiceOwnerDto>().ReverseMap();

            CreateMap<Service, ServiceRegisterDto>().ReverseMap();

            CreateMap<CreateReservationDto, Reservation>().ReverseMap();
        }
    }
}
