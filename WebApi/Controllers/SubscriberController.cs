using Microsoft.AspNetCore.Mvc;
using Business.DTOs;
using Business.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriberController(SubscriberService subscriberService) : ControllerBase
    {
        private readonly SubscriberService _subscriberService = subscriberService;

        [HttpPost]
        public async Task<IActionResult> Subscribe(SubscriberDTO dto)
        {
            if (dto != null)
            {
                var isSubscribed = await _subscriberService.IsSubscribedAsync(dto.Email);

                if (isSubscribed)
                {
                    return Conflict("Subscriber with the provided email already exists.");
                }

                await _subscriberService.CreateSubscriptionAsync(dto);
                return CreatedAtAction(nameof(Subscribe), dto);
            }

            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> Unsubscribe(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                var isRemoved = await _subscriberService.RemoveSubscriberAsync(email);
                
                if (isRemoved)
                {
                    return Ok("Email has been unsubscribed");
                }
                else
                {
                    return NotFound("Email not found");
                }
            }

            return BadRequest();
        }
    }
}
