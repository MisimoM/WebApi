using Business.DTOs;
using Business.Mapper;
using Infrastructure.Repositories;
using System.Diagnostics;

namespace Business.Services
{
    public class SubscriberService(SubscriberRepository subscriberRepository)
    {
        private readonly SubscriberRepository _subscriberRepository = subscriberRepository;

        public async Task CreateSubscriptionAsync(SubscriberDTO subscriberDTO)
        {
            try
            {
                var subscriberEntity = SubscriberMapper.MapToEntity(subscriberDTO);
                await _subscriberRepository.AddAsync(subscriberEntity);
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
        }
    }
}
