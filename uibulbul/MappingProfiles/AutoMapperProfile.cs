using AutoMapper;
using uibulbul.DTO;
using uibulbul.Models;
namespace uibulbul.MappingProfiles
    
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Vehicle, VehicleDTO>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model))
                .ForMember(dest => dest.FuelTypes, opt => opt.MapFrom(src => src.FuelTypes))
                .ForMember(dest => dest.Capacity, opt => opt.MapFrom(src => src.Capacity));
        }
    }
}
