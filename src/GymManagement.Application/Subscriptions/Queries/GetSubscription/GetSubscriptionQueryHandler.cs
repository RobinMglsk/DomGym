using ErrorOr;
using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using MediatR;

namespace GymManagement.Application.Subscriptions.Queries.GetSubscription;

public class GetSubscriptionQueryHandler : IRequestHandler<GetSubscriptionQuery, ErrorOr<Subscription>>
{

    private readonly ISubscriptionsRepository _subscriptionsRepository;

    public GetSubscriptionQueryHandler(ISubscriptionsRepository subscriptionsRepository) // IUnitOfWork unitOfWork)
    {
        _subscriptionsRepository = subscriptionsRepository;
        // _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Subscription>> Handle(GetSubscriptionQuery request, CancellationToken cancellationToken)
    {
        var subscription = await _subscriptionsRepository.GetByIdAsync(request.subscriptionId);
        // await _unitOfWork.CommitChangesAsync();

        return subscription is null
            ? Error.NotFound(description: "Subscription not found")
            : subscription;
    }
}