using AutoMapper;
using ScooterDAL.Entities;
using Scooter.BLL.DTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Scooter.BLL.MappingProfiles
{
    public class ScooterProfile : Profile
    {
        public ScooterProfile()
        {
            // User <-> UserDTO
            CreateMap<User, UserDTO>().ReverseMap();

            // Trip <-> TripDTO з додатковими полями
            CreateMap<Trip, TripDTO>()
                .ForMember(dest => dest.UserFullName, opt => opt.MapFrom(src => src.User.FullName))
                .ForMember(dest => dest.VehicleModel, opt => opt.MapFrom(src => src.Vehicle.Model))
                .ReverseMap();

            // Payment <-> PaymentDTO з додатковими полями
            CreateMap<Payment, PaymentDTO>()
                .ForMember(dest => dest.UserFullName, opt => opt.MapFrom(src => src.User.FullName))
                .ForMember(dest => dest.TripDescription, opt => opt.MapFrom(src => $"Trip {src.TripId}"))
                .ReverseMap();

            // Vehicle <-> VehicleDTO
            CreateMap<Vehicle, VehicleDTO>().ReverseMap();

            // Feedback <-> FeedbackDTO з додатковим полем
            CreateMap<Feedback, FeedbackDTO>()
                .ForMember(dest => dest.UserFullName, opt => opt.MapFrom(src => src.User.FullName))
                .ReverseMap();
        }
    }
}
