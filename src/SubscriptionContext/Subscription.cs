using JlucsxCourses.SharedContext;

namespace JlucsxCourses.SubscriptionContext;

public class Subscription : Base
{
    public Plan Plan { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsInactive
    {
        get
        {
            if (EndDate is null) 
                return false;
            return EndDate <= DateTime.Now;
        }
    }
}
