using Microsoft.EntityFrameworkCore;
using vega.Models;

namespace vega1_1.Persistance
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
        : base (options)
        {
            
        }

        public DbSet<Make> Makes { get; set; }
    }
}