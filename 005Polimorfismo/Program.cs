using System;

namespace _005Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Polimorfismo, vem da palavra polimorfo e significa que pode ter varias formas*/

            var pagamento = new Pagamentos();
            pagamento.ToString();
        }

        #region Classes Exemplos
        class Pagamentos
        {
            public DateTime Vencimento;

            //A palavra reservada virtual, permite que esse metodo possa ser sobrescrevido em outra classe;
            public virtual void Pagar()
            {

            }

            // 
            public override string ToString()
            {
                return Vencimento.ToString("dd/MM/yyyy");
            }
        }

        class PagamentoBoleto : Pagamentos
        {
            public string NumeroBoleto;

            /*Toda vez que usamos a palavra virtual para sobrescrever um metodo de outra classe, ao declarar este metodo
             na classe onde iremos instancialo, devemos incluir a palavra override como no ex abaixo:*/
            public override void Pagar()
            {
                base.Pagar();
                //Regra do boleto;
            }
        }

        class PagamentoCartao : Pagamentos
        {
            public string Numero;

            public override void Pagar()
            {
                base.Pagar();
                //regra do cartão
            }
        }
        #endregion
    }
}
