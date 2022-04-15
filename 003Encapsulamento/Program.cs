using System;

namespace _003Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O encapsulamento é o primeiro pilar da Programação Orientada a Objetos*/

            /*
             Encapsular em programação, significa agrupar tudo que faz sentido estar junto.
            Exemplo de uma classe destinada a realizar o pagamento de uma empresa.
            Nesta classe temos, os nomes dos funcionarios, o valor a ser pago e etc..
             */

            Console.WriteLine();
        }
    }

    #region Pagamento
    class Paymants
    {
        // Todas as variaveis dentro de uma classe se tornam as propiedades desta;
        #region Propiedades
        //Data de vencimento, faz sentido estar nesta classe pagamentos
        DateTime Vencimento;
        #endregion

        // As funçoes por sua vez, se tornam os metodos
        #region Funcoes ou Metodos
        // Um metodo pagar, faz sentido estar dentro da classe pagamento
        void Pay()
        {

        }
        #endregion
    }
    #endregion
}
