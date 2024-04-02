﻿using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities.Api
{
    public class SubscriberEntity
    {
        [Key]
        public string Id { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;
        public bool DailyNewsletter { get; set; }
        public bool AdvertisingUpdates { get; set; }
        public bool WeekInReview { get; set; }
        public bool EventUpdates { get; set; }
        public bool StartupsWeekly { get; set; }
        public bool Podcasts { get; set; }

    }
}
