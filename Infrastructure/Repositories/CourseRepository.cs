using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories
{
    public class CourseRepository(ApiDbContext dbContext) : BaseRepository<CourseEntity>(dbContext)
    {
    }
}
