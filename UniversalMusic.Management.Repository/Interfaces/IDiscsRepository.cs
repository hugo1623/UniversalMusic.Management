using UniversalMusic.Management.Entity;

namespace UniversalMusic.Management.Repository.Interfaces
{
    public interface IDiscsRepository
    {
        Task<List<Disc>> GetDiscs();
        Task<Disc> GetDisc(int id);
        Task InsertDisc(Disc disc);
        Task UpdateDisc(Disc disc);
    }
}
