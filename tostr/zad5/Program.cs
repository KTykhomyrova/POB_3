namespace zad5
{
    interface IOperacjeBankowe
    {
        void Wplata(double kwota);
        bool Wyplata(double kwota);
    }

    abstract class Konto : IOperacjeBankowe
    {
        public double Stadlo;
        public int NumerKonta;

        protected Konto(int stadlo, int numerKonta)
        {
            Stadlo = stadlo;
            NumerKonta = numerKonta;
        }

        public virtual void Wplata(double kwota)
        {
            Stadlo += kwota;
            Console.WriteLine($"Kwota {kwota} była wpłacona. Twój stan konta: {Stadlo}");
        }

        public virtual bool Wyplata(double kwota)
        {
            if (Stadlo >= kwota)
            {
                Stadlo -= kwota;
                return true;
                   
            }
            else
            {
                return false;
            }
        }
    }

    class KontoOsobiste : Konto
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
