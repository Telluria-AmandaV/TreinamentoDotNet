using System.Collections.Generic;
using ProjetoPOO.NotificationContext;

namespace ProjetoPOO
{
    public class Article : Content
    {
        public IList<Notification> Notificarions { get; set; }
        public Article(string title, string url) : base(title, url)
        {

        }

    }
}