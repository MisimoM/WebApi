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

        public async Task<bool> RemoveSubscribtionAsync(string email)
        {
            try
            {
                var subscriberEntity = await _subscriberRepository.GetAsync(subscriber => subscriber.Email == email);

                if (subscriberEntity != null)
                {
                    return await _subscriberRepository.DeleteAsync(subscriber => subscriber.Email == email);
                }
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }

            return false;
        }

        public async Task<bool> IsSubscribedAsync(string email)
        {
            try
            {
                var existingSubscriber = await _subscriberRepository.GetAsync(subscriber => subscriber.Email == email);

                return existingSubscriber != null;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }

            return false;
        }
    }
}
