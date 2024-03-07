using Microsoft.AspNetCore.Mvc;
using GymManagement.Contracts.Subscription;

namespace GymManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionsController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateSubscription(CreateSubscriptionRequest request)
    {
        return Ok(request);
    }
}