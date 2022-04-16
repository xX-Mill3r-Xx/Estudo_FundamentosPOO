using System;

namespace _012ClassesSeladas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Para evitar que uma classe possa ser extendida, usamos a palavra reservada sealed*/
        }

        public sealed class Pagamento
        {
            public DateTime Vencimento { get; set; }
        }

        #region Exemplo
        /*
           public class PagamentoBoleto : Pagamento
           {
                //este codigo não funciona pois a classe pagamento não pode ser extendida;
           }

         */
        #endregion

    }
}
