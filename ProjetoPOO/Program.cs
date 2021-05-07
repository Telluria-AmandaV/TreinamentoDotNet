using System.Collections.Generic;

namespace ProjetoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre POO", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre c#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            // foreach(var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            // }

            var courses = new List<Course>();
            var course = new Course("Fundamentos POO", "fundamentos-poo");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-dotnet");
            courses.Add(course);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem2 = new CareerItem(2, "Aprenda POO", "", course);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);


        }
    }
}
