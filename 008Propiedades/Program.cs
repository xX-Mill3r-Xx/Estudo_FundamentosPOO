using System;

namespace _008Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            /**/
        }

        public class Pagamentos
        {
            //Uma propiedade
            public DateTime Vencimento { get; set; }

            /*Para ler um valor passamos pelo metodo get;
              Para atribuir um valor, usamos  metodo set;*/

            private int _numero;

            public int NumeroPagamento
            {
                //Lendo o valor;
                get { return _numero; }

                //Atribuindo o valor
                set { _numero = value; }
            }


            public void Pagar()
            {

            }
        }
    }
}
