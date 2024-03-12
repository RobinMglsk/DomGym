using GymManagements.Domain.Subscriptions;

namespace GymManagement.Application.Common.Interfaces;

public interface ISubscriptionsRepository
{
    Task AddSubscriptionAsync(Subscription subscription);

    Task<Subscription?> GetByIdAsync(Guid subscriptionId);
}