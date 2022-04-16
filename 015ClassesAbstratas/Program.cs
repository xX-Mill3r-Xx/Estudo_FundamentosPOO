using System;

namespace _015ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O abstract significa que a classe não pode ser instanciada*/
            //var pagamento = new Payment(); => não funciona;
        }
    }

    public abstract class Payment : IPayment
    {
        public DateTime Vencimento { get; set; }

        public virtual void Pagar(double valor)
        {
            throw new NotImplementedException();
            // Executar
        }
    }

    public class PagamentoCartao : Payment
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }

    public interface IPayment
    {
        //Na interfaçe, temos todos os padroes que uma classe deve implementar;
        DateTime Vencimento { get; set; }
        void Pagar(double valor);
    }
}
