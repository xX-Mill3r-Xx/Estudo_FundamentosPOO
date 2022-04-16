using System;

namespace _013PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment pag = new Payment();
            pag.PropiedadeA = 10;
            pag.PropiedadeB = 20;

            Console.WriteLine(pag.PropiedadeA);
            Console.WriteLine(pag.PropiedadeB);
            Console.ReadKey();
        }
    }
}
