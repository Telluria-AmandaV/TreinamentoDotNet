using ProjetoPOO.NotificationContext;
using ProjetoPOO.SharedContext;

namespace ProjetoPOO
{
    public class CareerItem : Base
    {
        public CareerItem(int ordem, string title, string description, Course course)
        {
            Ordem = ordem;
            Title = title;
            Description = description;
            Course = course;

            if (course == null)
                AddNotification(new Notification("Course", "Curso inválido!"));
        }

        public int Ordem { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}