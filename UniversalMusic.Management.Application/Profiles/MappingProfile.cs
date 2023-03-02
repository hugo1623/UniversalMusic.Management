using AutoMapper;
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
            CreateMap<ArtistForCreateDto, Artist>().ReverseMap();
            CreateMap<ArtistForEditDto,Artist>().ReverseMap();

            CreateMap<Disc, DiscForListDto>();
            CreateMap<Disc, DiscForDetailDto>();
            CreateMap<DiscForCreateDto, Disc>().ReverseMap();
            
        }
    }
}
