using JlucsxCourses.SharedContext;

namespace JlucsxCourses.SubscriptionContext;

public class Student : Base
{
    public Student()
    {
        Subscriptions = new List<Subscription>();
    }

    public User User { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public IList<Subscription> Subscriptions { get; set; }
    public bool IsPremium
        => Subscriptions
            .Any(sub => !sub.IsInactive);
    
    public void CreateSubscription(Subscription subscription)
    {
        if (IsPremium)
        {
            AddNotification(new("Premium", "O aluno já tem uma assinatura ativa."));
            return;
        }
        Subscriptions.Add(subscription);
    }
}
