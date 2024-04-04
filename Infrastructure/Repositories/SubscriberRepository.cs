using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories
{
    public class SubscriberRepository(ApiDbContext dbContext) : BaseRepository<SubscriberEntity>(dbContext)
    {
    }
}
