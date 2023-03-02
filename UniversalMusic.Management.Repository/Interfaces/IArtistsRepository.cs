using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversalMusic.Management.Entity;

namespace UniversalMusic.Management.Repository.Interfaces
{
    public interface IArtistsRepository
    {
        Task<List<Artist>> GetArtists();
        Task<Artist> GetArtist(int id);
        Task InsertArtist(Artist artist);
    }
}
