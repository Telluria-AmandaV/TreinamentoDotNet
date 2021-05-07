
using ProjetoPOO.SharedContext;

namespace ProjetoPOO
{
    public abstract class Content : Base
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public Content(string title, string url)
        {
            Title = title;
            Url = Url;
        }
    }
}