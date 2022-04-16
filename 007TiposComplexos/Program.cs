using System;

namespace _007TiposComplexos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Toda vez que criamos uma classe, estamos de fato criando um novo tipo*/
        }

        #region Exemplos
        //Tipo complexo
        public class Pagamento
        {
            DateTime Vencimento;
            Address BillingAdress;

            void Pagar()
            {

            }
        }

        public class Address
        {
            string zipCode;
        }
        #endregion
    }
}
