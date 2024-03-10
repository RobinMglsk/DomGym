using Microsoft.AspNetCore.Mvc;
using GymManagement.Contracts.Subscription;
using GymManagement.Application.Services;

namespace GymManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionsController : ControllerBase
{

    private readonly ISubscriptionsService _subscriptionService;

    public SubscriptionsController(ISubscriptionsService subscriptionsService)
    {
        _subscriptionService = subscriptionsService;
    }

    [HttpPost]
    public IActionResult CreateSubscription(CreateSubscriptionRequest request)
    {
        var subscriptionId = _subscriptionService.CreateSubscription(
            request.SubscriptionType.ToString(),
            request.AdminId
        );

        var response = new SubscriptionResponse(subscriptionId, request.SubscriptionType);

        return Ok(response);
    }
}