using UniversalMusic.Management.Application.Dtos;
using UniversalMusic.Management.Entity;

namespace UniversalMusic.Management.Application.Interfaces
{
    public interface IArtistsApplication
    {
        Task<List<ArtistForListDto>> GetArtists();
        Task<ArtistDetailDto> GetArtist(int id);
        Task InsertArtist(ArtistForCreateDto artistForCreateDto);
    }
}
