using System;
using System.Collections.Generic;
using System.Linq;

namespace _023ListasPt02
{
    class Program
    {
        static void Main(string[] args)
        {
            /**/
            var payments = new List<Payment>();
            payments.Add(new Payment(1));
            payments.Add(new Payment(2));
            payments.Add(new Payment(3));
            payments.Add(new Payment(4));
            payments.Add(new Payment(5));

            Console.WriteLine("payments");
            foreach (var payment in payments)
            {
                Console.WriteLine($"Id do pagamento {payment.Id}");
            }

            Console.WriteLine();
            var paidPayments = new List<Payment>();
            paidPayments.AddRange(payments);
            Console.WriteLine("paidPayments");
            foreach (var payment in paidPayments)
            {

                Console.WriteLine($"Id do pagamento {payment.Id}");
            }

            Console.WriteLine();
            var paymentsId = payments.First(x => x.Id == 3);
            Console.WriteLine(paymentsId.Id);

            payments.Remove(paymentsId);
        }
    }

    public class Payment
    {
        public int Id { get; set; }

        public Payment(int id)
        {
            Id = id;
        }
    }
}
