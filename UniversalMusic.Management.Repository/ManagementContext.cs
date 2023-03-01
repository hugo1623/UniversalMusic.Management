

using Microsoft.EntityFrameworkCore;
using UniversalMusic.Management.Entity;

namespace UniversalMusic.Management.Repository
{
    public class ManagementContext : DbContext
    {
        public ManagementContext(DbContextOptions<ManagementContext> options) : base(options) { 
        
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Disc> Discs { get; set; }
    }
}
