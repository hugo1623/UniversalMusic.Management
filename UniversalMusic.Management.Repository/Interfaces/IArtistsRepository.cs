using UniversalMusic.Management.Entity;

namespace UniversalMusic.Management.Repository.Interfaces
{
    public interface IArtistsRepository
    {
        Task<List<Artist>> GetArtists();
        Task<Artist> GetArtist(int id);
        Task InsertArtist(Artist artist);
        Task UpdateArtist(Artist artist);
        Task DeleteArtist(Artist artist);
    }
}
