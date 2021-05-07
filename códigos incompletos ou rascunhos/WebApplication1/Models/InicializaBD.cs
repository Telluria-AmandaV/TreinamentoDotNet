using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public static class InicializaBD
    {
        public static void Initialize(CadContext cont)
        {
            if(cont.Cadastros.Any())
            {
                return;
            }
            var cadastros = new Cadastro[]
            {
                new Cadastro("46525564578", "Maria", "Rua da pracinha", "40028922", 3)
            };
            foreach (Cadastro c in cadastros)
            {
                cont.Cadastros.Add(c);
            }
            cont.SaveChanges();
        }
    }
}
