using System;

namespace _010UsingDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var pagamento = new Pagamento())
            {
                Console.WriteLine("Processando pagamento");
            }
        }
    }

    public class Pagamento : IDisposable
    {
        public Pagamento()
        {
            Console.WriteLine("Iniciando Pagamento");
        }

        public void Dispose()
        {
            Console.WriteLine("Finalizando Pagamento");
        }
    }
}
