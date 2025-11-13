using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    abstract class Zwierze
    {
        public string Nazwa { get; protected set; }
        public int Wiek { get; protected set; }

        public abstract void WydajDzwiek();
        public abstract void Jedz();
    }

    class Lew : Zwierze
    {
        public override void WydajDzwiek()
        {
            Console.WriteLine("Roar!");
        }

        public override void Jedz()
        {
            Console.WriteLine("Ja jem mięso");
        }
    }

    class Slon : Zwierze
    {
        public override void WydajDzwiek()
        {
            Console.WriteLine("Bruu");
        }

        public override void Jedz()
        {
            Console.WriteLine("Ja jem trawę");
        }
    }

    class Papuga : Zwierze
    {
        public override void WydajDzwiek()
        {
            Console.WriteLine("Pi pi!");
        }

        public override void Jedz()
        {
            Console.WriteLine("Ja jem kwiaty");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SymulacjaDnia();

            Console.ReadKey();
        }

        private static void SymulacjaDnia()
        {
            List<Zwierze> zwierzeta = new List<Zwierze>()
            {
                new Lew(),
                new Slon(),
                new Papuga()
            };

            Random rand = new Random();

            for (int i = 0; i < zwierzeta.Count; i++)
            {
                int los1 = rand.Next(zwierzeta.Count);
                int los2 = rand.Next(zwierzeta.Count);
                (zwierzeta[los1], zwierzeta[los2]) = (zwierzeta[los2], zwierzeta[los1]);
            }

            foreach (var z in zwierzeta)
            {
                int metod = rand.Next(2);
                if (metod == 0)
                    z.WydajDzwiek();
                else
                    z.Jedz();
            }
        }
    }
}
