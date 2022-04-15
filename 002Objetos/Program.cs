using System;

namespace _002Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Um objeto, sempre vai ser um tipo de referencia*/
            // Um tipo referencia só armazena um endereço dos dados

            #region Exemplo com struct
            //declarando um objeto
            var customer = new Customer();
            customer.Name = "Teste com struct";
            Console.WriteLine(customer);
            #endregion

            #region Exemplo com Classe
            var customerClass = new CustomerClass();
            customerClass.Name = "Teste com Classe";
            Console.WriteLine(customerClass);
            #endregion
        }
    }

    #region Struct Customer
    struct Customer
    {
        public string Name;
    }
    #endregion

    //A classe acaba sendo um molde para o objeto;
    #region Customer Classe
    public class CustomerClass
    {
        public string Name;
    }
    #endregion
}
