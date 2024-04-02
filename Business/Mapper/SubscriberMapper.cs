using Business.DTOs;
using Infrastructure.Entities.Api;

namespace Business.Mapper
{
    public class SubscriberMapper
    {
        public static SubscriberEntity MapToEntity(SubscriberDTO dto)
        {
            return new SubscriberEntity
            {
                Id = Guid.NewGuid().ToString(),
                Email = dto.Email,
                DailyNewsletter = dto.DailyNewsletter,
                AdvertisingUpdates = dto.AdvertisingUpdates,
                WeekInReview = dto.WeekInReview,
                EventUpdates = dto.EventUpdates,
                StartupsWeekly = dto.StartupsWeekly,
                Podcasts = dto.Podcasts
            };
        }
    }
}
