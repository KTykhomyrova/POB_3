using System;
using System.Collections.Generic;

namespace Zadanie3
{
    internal class Program
    {
        abstract class KontoBankowe
        {
            private decimal _stadlo;
            public decimal Stadlo
            {
                get { return _stadlo; }
                protected set { _stadlo = value; }
            }

            public KontoBankowe(decimal saldoPoczatkowe = 0)
            {
                _stadlo = saldoPoczatkowe;
            }


            public void Wplac(decimal kwota)
            {
                if (kwota <= 0)
                {
                    Console.WriteLine("Kwota wpłaty musi być dodatnia");
                    return;
                }
                _stadlo += kwota;
            }

            public virtual void Wyplac(decimal kwota)
            {
                if (kwota <= 0)
                {
                    Console.WriteLine("Kwota wypłaty musi być dodatnia");
                    return;
                }
                _stadlo -= kwota;
            }
        }

        class KontoOszczednosciowe : KontoBankowe
        {
            public KontoOszczednosciowe(decimal saldoPoczatkowe = 0) : base(saldoPoczatkowe) { }

            public override void Wyplac(decimal kwota)
            {
                if (Stadlo - kwota < 0)
                {
                    Console.WriteLine("Nie można wypłacić saldo nie może spaść poniżej zera");
                    return;
                }
                base.Wyplac(kwota);
            }

            public void ObliczOdsetki()
            {
                decimal odsetki = Stadlo * 0.02m;
                Wplac(odsetki);
            }
        }


        class KontoPremium : KontoBankowe
        {
            public KontoPremium(decimal saldoPoczatkowe = 0) : base(saldoPoczatkowe) { }

            public override void Wyplac(decimal kwota)
            {
                if (Stadlo - kwota < -1000)
                {
                    Console.WriteLine("Przekroczono dopuszczalny debet");
                    return;
                }
                base.Wyplac(kwota);
            }
            static void Main(string[] args)
            {
                var konto1 = new KontoPremium(200);
                var konto2 = new KontoOszczednosciowe(400);

                konto1.Wplac(300);
                konto1.Wyplac(600);
                konto1.Wyplac(800);

                konto2.Wplac(100);
                konto2.Wyplac(200);
                konto2.Wyplac(400);

                konto2.ObliczOdsetki();

                Console.WriteLine("Stan końcowy kont");
                Console.WriteLine($"Konto Premium: {konto1.Stadlo} zł");
                Console.WriteLine($"Konto Oszczędnościowe: {konto2.Stadlo} zł");

                Console.ReadKey();
            }
        }
    }
}
