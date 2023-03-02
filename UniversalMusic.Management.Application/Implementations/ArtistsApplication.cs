using AutoMapper;
using UniversalMusic.Management.Application.Dtos;
using UniversalMusic.Management.Application.Interfaces;
using UniversalMusic.Management.Entity;
using UniversalMusic.Management.Repository.Interfaces;

namespace UniversalMusic.Management.Application.Implementations
{
    public class ArtistsApplication : IArtistsApplication
    {
        private IArtistsRepository artistsRepository;
        private IMapper mapper;

        public ArtistsApplication(IArtistsRepository artistsRepository, IMapper mapper)
        {
            this.artistsRepository = artistsRepository;
            this.mapper= mapper;
        }
        public async Task<List<ArtistForListDto>> GetArtists()
        {
            var artists = await artistsRepository.GetArtists();
            var artistsDto = mapper.Map<List<ArtistForListDto>>(artists);
            return artistsDto;
        }
        public async Task<ArtistDetailDto> GetArtist(int id)
        {
            var artist = await artistsRepository.GetArtist(id);
            var artistDto = mapper.Map<ArtistDetailDto>(artist);
            return artistDto;
        }

        public async Task InsertArtist(ArtistForCreateDto artistForCreateDto)
        {
            var artistEntity = mapper.Map<Artist>(artistForCreateDto);
            await artistsRepository.InsertArtist(artistEntity);
        }
    }
}
