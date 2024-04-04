using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public partial class ApiDbContext(DbContextOptions<ApiDbContext> options) : DbContext(options)
    {
        public virtual DbSet<SubscriberEntity> Subscribers { get; set; }
        public virtual DbSet<CourseEntity> Courses { get; set; }
    }
}
