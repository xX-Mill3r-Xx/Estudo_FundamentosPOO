using System;

namespace _021GenericsPt02
{
    class Program
    {
        static void Main(string[] args)
        {
            /**/
            var person = new Person();
            var payment = new Payment();
            var sub = new Subscription();

            var context = new DataContext<IPerson, Payment, Subscription>();

            context.Save(person);
            context.Save(payment);
            context.Save(sub);
        }

        //Classe generica
        public class DataContext<P, PA, S>
            where P : IPerson
            where PA : Payment
            where S : Subscription
        {
            public void Save(P entity)
            {
                Console.WriteLine("Arquivo salvo");
            }

            public void Save(PA entity)
            {
                Console.WriteLine("Arquivo salvo");
            }

            public void Save(S entity)
            {
                Console.WriteLine("Arquivo salvo");
            }
        }

        public interface IPerson { }

        public class Person : IPerson { }

        public class Payment { }

        public class Subscription { }
    }
}
