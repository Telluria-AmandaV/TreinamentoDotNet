using System.Collections.Generic;
using System.Linq;

namespace ProjetoPOO.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }

        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddRangeNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }
        public bool IsValid => Notifications.Any();

    }
}