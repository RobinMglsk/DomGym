using ErrorOr;
using GymManagements.Domain.Subscriptions;
using MediatR;

namespace GymManagement.Application.Subscriptions.Queries.GetSubscription;

public record GetSubscriptionQuery(Guid subscriptionId) : IRequest<ErrorOr<Subscription>>;