using System;

namespace Teste
{
    /// informações adicionais para a classe
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'b';
            decimal numero = 2m;
            int numero2 = 24;
            numero = letra;
            letra = (char)numero2;
            Console.WriteLine(numero);
            Console.WriteLine(letra);
        }
    }
}
