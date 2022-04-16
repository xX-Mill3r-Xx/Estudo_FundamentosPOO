using System;

namespace _017ComparandoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /**/

            var pessoa1 = new Pessoa(1,"Miller");
            var pessoa2 = new Pessoa(1,"Miller"); 

            Console.WriteLine(pessoa1.Id == pessoa2.Id);
            //true

            Console.WriteLine(pessoa1.Equals(pessoa2));
            //true
        }
    }

    public class Pessoa : IEquatable<Pessoa>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Pessoa(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public bool Equals(Pessoa other)
        {
            return Id == other.Id;
        }
    }
}
