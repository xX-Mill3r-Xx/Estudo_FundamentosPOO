using System;

namespace _020GenericsPt01
{
    class Program
    {
        static void Main(string[] args)
        {
            /**/
            var person = new Person();
            var pay = new Payment();

            var context = new DataContext<Person>();
            var payment = new DataContext<Payment>();

            context.Save(person);
            payment.Save(pay);
        }
    }

    //Classe generica
    public class DataContext<T>
    {
        public void Save(T entity)
        {
            Console.WriteLine("Arquivo salvo");
        }
    }

    public class Person { }

    public class Payment { }

    public class Subscription { }
}
