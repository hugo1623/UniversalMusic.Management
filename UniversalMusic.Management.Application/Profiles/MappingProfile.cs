﻿using AutoMapper;
using UniversalMusic.Management.Application.Dtos;
using UniversalMusic.Management.Entity;

namespace UniversalMusic.Management.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Artist, ArtistForListDto>();
            CreateMap<Artist, ArtistDetailDto>();
            CreateMap<ArtistForCreateDto, Artist>();
            
        }
    }
}