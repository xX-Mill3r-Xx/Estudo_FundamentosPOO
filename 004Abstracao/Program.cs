using System;

namespace _004Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O conceito de abstração, vem da necessidade de abstrair, esconder tudo que não precisa ter acesso*/

            /*Quanto menos exposto for um objeto, melhor sera o codigo*/

        }

        #region Classe Pagamento
        class Pagamnetos
        {
            DateTime Vencimento;

            //Metodo Publico
            public void Pagar()
            {
                //Podemos declarar metodos privados dentro de metodos publicos
                ConsultarSaldo("123");
            }

            //Metodo Privado;
            private void ConsultarSaldo(string numero)
            {
                //Aqui dentro contem as operaçoes as quais serão privadas das outras classes
            }
        }
        #endregion
    }
}
