using System;

namespace _014Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uma interface é um contrato que informa como a classe deve ser implementada; */
        }
    }

    public class PagamentoCartao : IPayment
    {
        public DateTime Vencimento { get; set; }

        public void Pagar(double valor)
        {
            throw new NotImplementedException();
        }
    }

    public class Payment : IPayment
    {
        public DateTime Vencimento { get; set; }

        public void Pagar(double valor)
        {
            throw new NotImplementedException();
        }
    }

    public interface IPayment
    {
        //Na interfaçe, temos todos os padroes que uma classe deve implementar;

        DateTime Vencimento { get; set; }
        void Pagar(double valor);
    }
}
