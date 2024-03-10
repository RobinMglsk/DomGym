namespace GymManagement.Application.Services;

public class SubscriptionsService : ISubscriptionsService
{

    public Guid CreateSubscription(string SubscriptionType, Guid AdminId)
    {
        return Guid.NewGuid();
    }
}