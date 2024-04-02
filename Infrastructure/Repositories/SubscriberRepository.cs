using Infrastructure.Contexts;
using Infrastructure.Entities.Api;

namespace Infrastructure.Repositories
{
    public class SubscriberRepository(ApiDbContext dbContext) : BaseRepository<SubscriberEntity>(dbContext)
    {
    }
}
