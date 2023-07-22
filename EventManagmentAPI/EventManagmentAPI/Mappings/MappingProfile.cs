using AutoMapper;
using EventManagmentAPI.Models;
using EventManagmentAPI.DTOs;

namespace EventManagmentAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EventDto, Event>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        }
    }
}
