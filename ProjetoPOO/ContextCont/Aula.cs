using ProjetoPOO.ContextCont.Enums;
using ProjetoPOO.SharedContext;

namespace ProjetoPOO
{
    public class Aula : Base
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}