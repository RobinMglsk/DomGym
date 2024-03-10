using ErrorOr;
using GymManagement.Application.Common.Interfaces;
using GymManagements.Domain.Subscriptions;
using MediatR;

namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription;

public class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, ErrorOr<Subscription>>
{

    private readonly ISubscriptionsRepository _subscriptionsRepsoitory;
    private readonly IUnitOfWork _unitOfWork;

    public CreateSubscriptionCommandHandler(ISubscriptionsRepository subscriptionsRepsoitory, IUnitOfWork unitOfWork)
    {
        _subscriptionsRepsoitory = subscriptionsRepsoitory;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Subscription>> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
    {
        var subscription = new Subscription
        {
            Id = Guid.NewGuid()
        };

        await _subscriptionsRepsoitory.AddSubscriptionAsync(subscription);
        await _unitOfWork.CommitChangesAsync();

        return subscription;
    }
}