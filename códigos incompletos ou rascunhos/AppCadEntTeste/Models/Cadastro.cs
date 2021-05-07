using System;

namespace AppCadEntTeste.Models
{
    public class Cadastro
    {
        public Guid Id { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public int Genero { get; set; }
        //public Cadastro()	{    }
    }
}
