using System;

namespace _006ModificadoresDeAcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Os modificadores de acesso extendem as classe, propiedades e metodos;
             Podemos ter modificadores tanto em classes, propiedades e metodos;*/

            /*Em C# temos os seguintes modificadores de acesso:
             - Private
             - Proteced
             - Internal
             - Public
            
             private = só é isivel dentro da classe
             protected = só é vizivel para as classes filhas da classe base
             internal = sempre que definimos como internal, o objeto fica disponivel dentro do assembly
             public = fica disponivel como um todo;*/
        }

        #region Exemplos
        //Se não declararmos o aceeso da classe, por padrao ela sera private
        public class Pagamento
        {
            //Este atributo esta definido como private portanto, só é visivel dentro desta classe;
            private DateTime Vencimento;

            //Este atributo esta definido como protected portanto, pode ser acessado de uma classe que herda desta classe;
            protected DateTime VencimentoProtected;

            //Este metodo esta definido como private portanto, só é visivel dentro desta classe;
            private void Pagar()
            {

            }
        }

        public class PagamentoBoleto : Pagamento
        {
            void Teste()
            {
                //Exemplo de chamada protected;
                base.VencimentoProtected.Date.ToString();
            }
        }
        #endregion
    }
}
