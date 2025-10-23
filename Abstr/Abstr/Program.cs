namespace Abstr
{
    internal class Program
    {

        abstract class Figura
        {
            public abstract double Pole();
            public abstract double Obwod();
        }
        class Kolo : Figura
        {
            public override double Pole()
            {
                Console.WriteLine("Podaj radius");
                var r = double.Parse(Console.ReadLine());
                return r * r * Math.PI;
            }

            public override double Obwod()
            {
                Console.WriteLine("Podaj radius");
                var r = double.Parse(Console.ReadLine());
                return Math.PI * r * 2;
            }
        }
        class Prosokat : Figura
        {
            public override double Pole()
            {
                Console.WriteLine("Podaj stronę a i b");
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());

                return a * b;
            }

            public override double Obwod()
            {
                Console.WriteLine("Podaj stronę a i b");
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());

                return (2*a) + (2*b);
            }
        }
        class Trojkat : Figura
        {
            public override double Pole()
            {
                Console.WriteLine("Podaj stronę a i h");
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());

                return (a * h) / 2;
            }

            public override double Obwod()
            {
                Console.WriteLine("Podaj stronę a, b i c");
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var c = double.Parse(Console.ReadLine());

                return a + b + c;
            }
        }
        static void Main(string[] args)
        {
            List < Figura > = new List<Figura>();
        }
    }
}
