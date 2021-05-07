using System;
using System.Globalization;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "oi eu estou pulando linhas e ignorando caracteres especiais";
            var texto2 = "oi eu sou um texto";
            var texto3 = "oi eu sou um texto";

            Console.WriteLine(texto);

            Console.WriteLine(texto.CompareTo(texto2)); //Compara exatamente e retorna 0 ou 1, mas por algum motivo está retornando -1
            Console.WriteLine(texto3.CompareTo(texto2));

            Console.WriteLine(texto.Contains(texto2));  // compara pedaço
            Console.WriteLine(texto.Contains(texto2, StringComparison.OrdinalIgnoreCase)); //compara seguindo um criterio, aqui ignorando maiusculas e minusculas
            
            Console.WriteLine(texto.StartsWith("oi", StringComparison.OrdinalIgnoreCase)); //retorna um booleano analisando o prefixo
            Console.WriteLine(texto.EndsWith("oi")); //analisa o prefixo
            
            Console.WriteLine(texto.Equals(texto3, StringComparison.OrdinalIgnoreCase)); //comparação exata e serve para vários tipos de objetos

            Console.WriteLine(texto2.IndexOf("to")); //passa o primerio indice onde encontra a string
            Console.WriteLine(texto2.LastIndexOf("e"));

            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto3.Insert(5, " lalala ")); //posicao para inserir, o que inserir
            Console.WriteLine(texto3.Remove(5, 6)); //onde começar a remover e o quanto remover
            Console.WriteLine(texto.Length);

            Console.WriteLine(texto.Replace("oi", "tchau")); //troca o primeiro pelo segundo

            var divisao = texto.Split(" "); //cria uma lista fazendo a separação
            Console.WriteLine(divisao[0]);
            var resultado = texto.Substring(5, 5);
            Console.WriteLine(resultado);
            Console.WriteLine(texto.Trim()); //limpa os espaços no inicio e no fim da string

            texto3 += texto2; //concatenação de strings pequenas
            Console.WriteLine(texto3);
            var texto4 = new StringBuilder(); //stringbuilder é diferente de string 
            texto4.Append(texto);
            texto4.Append(texto3);
            Console.WriteLine(texto4);

            //datas e tipo DateTime
            Console.Clear();

            var data = new DateTime(); //tem uma data padrão não nula
            Console.WriteLine(data); 

            data = DateTime.Now; //inicializa com a data atual
            Console.WriteLine(data);

            data = new DateTime(2020, 10, 12, 8, 23, 14);
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.DayOfWeek);

            data = DateTime.Now;
            // y - ano, M - mês, d - dia, h - hora, mm - minuto, s - segundo
            var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", data);
            Console.WriteLine(formatada);
            formatada = String.Format("{0:t}", data); //short time
            Console.WriteLine(formatada);
            formatada = String.Format("{0:T}", data); //por extenso
            Console.WriteLine(formatada);
            formatada = String.Format("{0:d}", data); //short day
            Console.WriteLine(formatada);
            formatada = String.Format("{0:D}", data); //por extenso
            Console.WriteLine(formatada);
            formatada = String.Format("{0:f}", data); //data e hora 
            Console.WriteLine(formatada);
            formatada = String.Format("{0:g}", data); //data e hora short
            Console.WriteLine(formatada);
            //r e R formatam no padrão do sistema, s para json e u é universal

            data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.AddDays(12)); //também existe para ano e mês, horas, minutos, segundos...

            Console.WriteLine(data);
            if (data == DateTime.Now){
                Console.WriteLine("é igual"); //pode não ser igual por causa dos milissegundos
            }
            if (data.Date == DateTime.Now.Date){
                Console.WriteLine("é igual"); //compara só a data 
            }

            Console.Clear();
            Console.WriteLine(DateTime.Now);
            var en = new CultureInfo("en-US");
            Console.WriteLine(DateTime.Now.ToString("D", en));
            var atual = CultureInfo.CurrentCulture;
            Console.WriteLine(DateTime.Now.ToString("D", atual));
            var dataT = DateTime.UtcNow; //hora universal
            Console.WriteLine(dataT);
            Console.WriteLine(dataT.ToLocalTime()); //converter para hora local
            var timezoneAust = TimeZoneInfo.FindSystemTimeZoneById("Cen. Australia Standard Time"); //procura o time zone
            Console.WriteLine(timezoneAust);
            var horaAust = TimeZoneInfo.ConvertTimeFromUtc(dataT, timezoneAust); //converter hora
            Console.WriteLine(horaAust);

            //pegando a lista de fusos
            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach(var timezone in timezones){
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dataT, timezone));
                Console.WriteLine("_______________");
            }

            Console.Clear();
            var timespan = new TimeSpan();
            Console.WriteLine(timespan);

            var timespannanoseg = new TimeSpan(1);
            Console.WriteLine(timespannanoseg);
            //passando 3 parametros coloca hora, minutos e segundos
            //com 4 é dia, hora, minutos e segundos
            //com 5 é 4+milissegundos
            //são muito usados para calcular datas e horarios



        }
    }
}
