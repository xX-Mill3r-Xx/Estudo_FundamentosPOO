using System;

namespace _018Delegates
{
    class Program
    {
        static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"pago o valor de {valor}");
        }

        static void Main(string[] args)
        {
            var pagar = new Payment.Pagar(RealizarPagamento);
            pagar(25);

            Console.WriteLine();
        }
    }

    public class Payment
    {
        public delegate void Pagar(double valor);
    }
}
