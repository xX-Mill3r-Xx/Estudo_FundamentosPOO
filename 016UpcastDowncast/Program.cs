using System;

namespace _016UpcastDowncast
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O processo de tornar um objeto filho em um objeto com os mesmos atributos do objeto pai é chamado de Upcasting*/
            /*O processo inverso é chamado de Downcasting*/

            //Upcasting
            var pessoa = new Person();
            pessoa = new Personal();
            pessoa = new Corporate();

            //Downcasting
            var pessoaFisica = new Personal();
            pessoaFisica = (Personal)pessoa;
        }
    }

    public class Person
    {
        //Classe base
        public string Name { get; set; }
    }

    //pessoa fisica
    public class Personal : Person
    {
        public string CPF { get; set; }
    }

    //pessoa juridica
    public class Corporate : Person
    {
        public string CNPJ { get; set; }
    }
}
