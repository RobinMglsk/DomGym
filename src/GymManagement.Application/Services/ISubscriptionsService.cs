namespace GymManagement.Application.Services;

public interface ISubscriptionsService
{
    Guid CreateSubscription(string stringsubscriptionType, Guid AdminId);
}