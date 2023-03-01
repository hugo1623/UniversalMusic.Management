using UniversalMusic.Management.Application.Interfaces;
using UniversalMusic.Management.Entity;
using UniversalMusic.Management.Repository.Interfaces;

namespace UniversalMusic.Management.Application.Implementations
{
    public class DiscsApplication : IDiscsApplication
    {
        private IDiscsRepository discsRepository;

        public DiscsApplication(IDiscsRepository discsRepository)
        {
            this.discsRepository= discsRepository;
        }
        public async Task<List<Disc>> GetDiscs()
        {
            var discs = await discsRepository.GetDiscs();
            return discs;
        }
        public async Task<Disc> GetDisc(int id)
        {
            var disc = await discsRepository.GetDisc(id);
            return disc;
        }
    }
}
