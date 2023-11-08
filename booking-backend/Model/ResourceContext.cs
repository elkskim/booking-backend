using Microsoft.EntityFrameworkCore;
using booking_backend.Model;

namespace booking_backend.Model
{
    public class ResourceContext : DbContext
    {
        public ResourceContext(DbContextOptions<ResourceContext> options) : base(options)
        {

        }

        public DbSet<Resource> Resource { get; set; } = null!;

        public DbSet<booking_backend.Model.Booking>? Booking { get; set; }
    }
}
