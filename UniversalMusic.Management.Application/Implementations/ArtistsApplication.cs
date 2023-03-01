using UniversalMusic.Management.Application.Interfaces;
using UniversalMusic.Management.Entity;
using UniversalMusic.Management.Repository.Interfaces;

namespace UniversalMusic.Management.Application.Implementations
{
    public class ArtistsApplication : IArtistsApplication
    {
        private IArtistsRepository artistsRepository;

        public ArtistsApplication(IArtistsRepository artistsRepository)
        {
            this.artistsRepository = artistsRepository;
        }
        public async Task<List<Artist>> GetArtists()
        {
            var artists = await artistsRepository.GetArtists();
            return artists;
        }
        public async Task<Artist> GetArtist(int id)
        {
            var artst = await artistsRepository.GetArtist(id);
            return artst;
        }
    }
}
