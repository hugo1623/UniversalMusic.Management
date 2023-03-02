using UniversalMusic.Management.Application.Dtos;

namespace UniversalMusic.Management.Application.Interfaces
{
    public interface IArtistsApplication
    {
        Task<List<ArtistForListDto>> GetArtists();
        Task<ArtistDetailDto> GetArtist(int id);
        Task InsertArtist(ArtistForCreateDto artistForCreateDto);
        Task UpdateArtist(int id, ArtistForEditDto artistForEditDto);
    }
}
