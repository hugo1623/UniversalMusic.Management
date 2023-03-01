using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversalMusic.Management.Entity;
using UniversalMusic.Management.Repository.Interfaces;

namespace UniversalMusic.Management.Repository.Implementations
{
    public class ArtistsRepository : IArtistsRepository
    {
        private ManagementContext context;

        public ArtistsRepository(ManagementContext context) 
        {
            this.context=context;
        }

        public async Task<List<Artist>> GetArtists()
        {
            var artists = await context.Artists.ToListAsync();
            return artists;
        }
        public async Task<Artist> GetArtist(int id)
        {
            var artist = await context.Artists.FirstOrDefaultAsync(x => x.Id == id); ;
            return artist;
        }

    }
}
