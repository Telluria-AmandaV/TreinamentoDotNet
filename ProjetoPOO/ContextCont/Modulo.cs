using System.Collections.Generic;
using ProjetoPOO.SharedContext;

namespace ProjetoPOO
{
    public class Module : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Aula> Aulas { get; set; }

        public Module()
        {
            Aulas = new List<Aula>();
        }
    }
}