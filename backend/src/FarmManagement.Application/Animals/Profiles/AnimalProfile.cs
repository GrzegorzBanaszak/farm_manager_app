using System;
using AutoMapper;
using FarmManagement.Application.Animals.Dtos;
using FarmManagement.Domain.Animals.Aggregate;

namespace FarmManagement.Application.Animals.Profiles;

public class AnimalProfile : Profile
{
    public AnimalProfile()
    {
        CreateMap<Animal, AnimalDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
            .ForMember(dest => dest.Tag, opt => opt.MapFrom(src => src.Tag.Value));
    }
}
