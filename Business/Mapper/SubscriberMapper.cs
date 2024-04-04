using Business.DTOs;
using Infrastructure.Entities;

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

        public static SubscriberDTO MapToDTO(SubscriberEntity entity)
        {
            return new SubscriberDTO
            {
                Email = entity.Email,
                DailyNewsletter = entity.DailyNewsletter,
                AdvertisingUpdates = entity.AdvertisingUpdates,
                WeekInReview = entity.WeekInReview,
                EventUpdates = entity.EventUpdates,
                StartupsWeekly = entity.StartupsWeekly,
                Podcasts = entity.Podcasts
            };
        }
    }
}
