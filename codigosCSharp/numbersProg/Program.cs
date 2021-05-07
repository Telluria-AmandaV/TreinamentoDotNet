using System;
using System.Globalization;

namespace numbersProg
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valor = 10.25M;
            Console.WriteLine(valor);
            Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("pt-BR"))); //formatação moeda
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); //colcoa o padrão da moeda
            Console.WriteLine(valor.ToString("E04", CultureInfo.CreateSpecificCulture("pt-BR"))); //NOTAÇÃO CIENTIFICA
            Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR"))); //porcentagem

            Console.WriteLine(Math.Round(valor)); //trunca
            Console.WriteLine(Math.Floor(valor)); //arredonda p baixo
            Console.WriteLine(Math.Ceiling(valor)); //arredonda p cima

            //funções para lista
            Console.Clear();
            var meuArray = new int[5]; //declarando um array de inteiros sempre com tamanho 
            Console.WriteLine(meuArray[0]);
            meuArray[0] = 12;
            Console.WriteLine(meuArray[0]);
            var meuArray2 = new int[5]{1, 2, 3, 4, 5}; //inicializando e preenchendo ao mesmo tempo
            Console.WriteLine(meuArray2[0]);

            Console.WriteLine(meuArray2.Length);
            

        }
    }
}
