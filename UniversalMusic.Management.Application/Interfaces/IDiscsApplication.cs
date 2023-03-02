using UniversalMusic.Management.Application.Dtos;
using UniversalMusic.Management.Entity;

namespace UniversalMusic.Management.Application.Interfaces
{
    public interface IDiscsApplication
    {
        Task<List<DiscForListDto>> GetDiscs();
        Task<DiscForDetailDto> GetDisc(int id);
        
    }
}
