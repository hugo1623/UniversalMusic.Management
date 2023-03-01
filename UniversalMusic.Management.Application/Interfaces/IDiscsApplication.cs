using UniversalMusic.Management.Entity;

namespace UniversalMusic.Management.Application.Interfaces
{
    public interface IDiscsApplication
    {
        Task<List<Disc>> GetDiscs();
        Task<Disc> GetDisc(int id);
    }
}
