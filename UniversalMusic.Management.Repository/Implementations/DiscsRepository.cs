using Microsoft.EntityFrameworkCore;
using UniversalMusic.Management.Entity;
using UniversalMusic.Management.Repository.Interfaces;

namespace UniversalMusic.Management.Repository.Implementations
{
    public class DiscsRepository : IDiscsRepository
    {
        private ManagementContext context;

        public DiscsRepository(ManagementContext context) 
        {
            this.context = context;
        }
        public async Task<List<Disc>> GetDiscs()
        {
            var discs = await context.Discs.ToListAsync();
            return discs;
        }
        public async Task<Disc> GetDisc(int id)
        {
            var disc = await context.Discs.FirstOrDefaultAsync(x => x.Id == id);
            return disc;
        }


    }
}
