using Dapr;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Subscriber.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private readonly ILogger<SubscriptionController> _logger;

        public SubscriptionController(ILogger<SubscriptionController> logger)
        {
            _logger = logger;
        }

        [Topic("pubsub", "bar")]
        [HttpPost("/bar")]
        public IActionResult PostWeathers(Foo foo)
        {
            _logger.LogInformation($"Foo posted: {foo.Data}");
            return NoContent();
        }
    }
}
