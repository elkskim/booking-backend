using Microsoft.EntityFrameworkCore;

namespace booking_backend.Model
{
    public class ResourceContext : DbContext
    {
        public ResourceContext(DbContextOptions<ResourceContext> options) : base(options)
        {

        }

        public DbSet<Resource> Resource { get; set; } = null!;
    }
}
