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
                await _subscriberService.CreateSubscriptionAsync(dto);
                return CreatedAtAction(nameof(Subscribe), dto);
            }

            return BadRequest();
        }
    }
}
