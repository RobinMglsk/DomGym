namespace GymManagements.Domain.Subscriptions;

public class Subscription
{
    public Guid Id { get; set; }
    public String SubscriptionType { get; set; } = "Free";
}