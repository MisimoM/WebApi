using Infrastructure.Entities.Api;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public partial class ApiDbContext(DbContextOptions<ApiDbContext> options) : DbContext(options)
    {
        public virtual DbSet<SubscriberEntity> Subscribers { get; set; }
    }
}
