using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversalMusic.Management.Entity;

namespace UniversalMusic.Management.Application.Interfaces
{
    public interface IDiscsApplication
    {
        Task<List<Disc>> GetDiscs();
        Task<Disc> GetDisc(int id);
    }
}
