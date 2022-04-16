using System;

namespace _011ClassesEstaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uma classe statica, siguinifica que esta classe não poderá ser instanciada;
             Quando uma classe é definida como static, esta classe ja fica disponivel;
            
             Ao definir uma classe como static, todos os seus membros tambem deverão ser staics*/

            Console.WriteLine($"Dia de pagamento {Pagamento.Vencimento = DateTime.Now}");
            Console.WriteLine($"Settings {Settings.API_URL}");
        }

        public static class Pagamento
        {
            //membro static
            public static DateTime Vencimento { get; set; }
        }

        public static class Settings
        {
            public static string API_URL { get; set; }
        }
    }
}
