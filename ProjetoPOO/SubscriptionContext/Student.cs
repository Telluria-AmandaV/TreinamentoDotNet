using System.Linq;
using System.Collections.Generic;
using ProjetoPOO.SharedContext;
using ProjetoPOO.NotificationContext;

namespace ProjetoPOO.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Nome { get; set; }
        public string Email {get; set; }
        public User User { get; set; }
        public List<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium){
                AddNotification(new Notification ("Premium", "O aluno já é premium"));
                return;
            }
            Subscriptions.Add(subscription);
        }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}