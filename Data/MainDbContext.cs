using Microsoft.EntityFrameworkCore;
using Weather.Models;

namespace Weather.Data
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
            
        }

        public DbSet<City> cities { get; set; }
    }
}
