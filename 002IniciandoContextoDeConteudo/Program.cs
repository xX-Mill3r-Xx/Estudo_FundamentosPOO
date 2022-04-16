using _002IniciandoContextoDeConteudo.ContentContext;
using _002IniciandoContextoDeConteudo.ContentContext.Enums;
using _002IniciandoContextoDeConteudo.NotificationContext;
using _002IniciandoContextoDeConteudo.SubscriptionContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _002IniciandoContextoDeConteudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            /**/

            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "conceitos-basicos-da-linguagem"));
            articles.Add(new Article("Artigo sobre .NET", "microsoft-framework"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
                Console.WriteLine();
            }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-asp.net");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            

            var careers = new List<Carrer>();
            var carrerDotNet = new Carrer("Especialista .NET", "especialista-dotnet");
            var carrerItem1 = new CarreirItem(1, "Começe por aqui", "", courseCsharp);
            var carrerItem2 = new CarreirItem(2, "Aprenda OOP", "", courseOOP);
            var carrerItem3 = new CarreirItem(3, "Aprenda .NET", "", courseAspNet);
            carrerDotNet.Items.Add(carrerItem2);
            carrerDotNet.Items.Add(carrerItem1);
            carrerDotNet.Items.Add(carrerItem3);
            careers.Add(carrerDotNet);
            
            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach(var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine($"Titulo: {item.Course?.Title}");
                    Console.WriteLine($"Nivel: {item.Course?.Level}");
                    Console.WriteLine();
                    foreach(var notifications in item.Notifications)
                    {
                        Console.WriteLine($"{notifications.Property} - {notifications.Message}");
                    }
                }
            }

            var payPalSub = new PayPalSubscription();
            var student = new Student();

            student.CreateSubscription(payPalSub);

            Console.ReadLine();
        }
    }
}
