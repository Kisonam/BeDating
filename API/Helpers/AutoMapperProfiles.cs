using System;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Extensions;
using AutoMapper;

namespace API.Helpers;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<AppUser, MemberDto>()
            .ForMember(dest => dest.Age, opt =>
                opt.MapFrom(src => src.DateOfBirth.CalculateAge()))
            .ForMember(d => d.PhotoUrl, o =>
                o.MapFrom(s => s.Photos.FirstOrDefault(x => x.IsMain)!.Url));


        CreateMap<Photo, PhotoDto>();
        // CreateMap<RegisterDto, AppUser>();
        // CreateMap<string, DateOnly>().ConvertUsing(s => DateOnly.Parse(s));
        // CreateMap<MemberUpdateDto, AppUser>();
        // .ForMember(dest => dest.Age, opt => 
        //     opt.MapFrom(src => src.DateOfBirth.CalculateAge()))
        // .ForMember(dest => dest.Photos, opt => 
        //     opt.MapFrom(src => src.Photos.Where(x => x.IsMain).FirstOrDefault()));

    }
}