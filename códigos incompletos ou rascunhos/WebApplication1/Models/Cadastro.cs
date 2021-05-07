using System;

namespace WebApplication1.Models
{
    public class Cadastro
    {
        public Guid Id { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public int Genero { get; set; }


        public Cadastro()	
        {    
        }

        public Cadastro(string cPF, string nome, string endereco, string telefone, int genero)
        {
            Id = Guid.NewGuid();
            CPF = cPF;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Genero = genero;
        }
    }
}
