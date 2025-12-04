namespace zad1
{
    interface IWyszukiwalne
    {
        bool Pasuje(string fraza);
    } 

    abstract class Publikacja : IWyszukiwalne
    {
        public string Tytul;
        public int RokWydania;

        protected Publikacja(string tytul, int rokWydania)
        {
            Tytul = tytul;
            RokWydania = rokWydania;
        }

        public abstract string Opis();

        virtual public bool Pasuje(string fraza)
        {
            if (Tytul.Contains(fraza))
            {
                return true;
            }
            return false;
        }
    }

    class Ksiazka : Publikacja
    {
        public string Autor;
        public int LiczbaStron;

        public Ksiazka(string tytul, int rokWydania, string autor, int liczbaStron) : base(tytul, rokWydania)
        {
            Autor = autor;
            LiczbaStron = liczbaStron;
        }

        public override string Opis()
        {
            return $"Książka, tytuł:{Tytul}, rok wydania:{RokWydania}, autor:{Autor}, liczba stron: {LiczbaStron}\n";
        }

        public override bool Pasuje(string fraza)
        {
            if (Tytul.Contains(fraza) || Autor.Contains(fraza))
            {
                return true;
            }
            return false;
        }
    }

    class Czasopismo : Publikacja
    {
        public int Numer;
        public bool Miesiecznik;
        public bool Tygodnik;

        public Czasopismo(string tytul, int rokWydania, int numer, bool miesiecznik, bool tygodnik) : base(tytul, rokWydania)
        {
            Numer = numer;
            Miesiecznik = miesiecznik;
            Tygodnik = tygodnik;
        }

        public override string Opis()
        {
            if (Miesiecznik)
            {
                return $"Czasopismo, tytuł:{Tytul}, rok wydania:{RokWydania}, numer:{Numer}, mięsięcznik:";
            }
            else
            {
                return $"Czasopismo, tytuł:{Tytul}, rok wydania:{RokWydania}, numer:{Numer}, tygodnik";
            }
        }
    }

    class Komiks : Publikacja
    {
        public string AutorRysunku;

        public Komiks(string tytul, int rokWydania, string autorRysunku) : base(tytul, rokWydania)
        {
            AutorRysunku = autorRysunku;
        }

        public override string Opis()
        {
            return $"Komiks, tytuł:{Tytul}, rok wydania:{RokWydania}, autor rysunku: {AutorRysunku}";
        }

        public override bool Pasuje(string fraza)
        {
            if (Tytul.Contains(fraza) || AutorRysunku.Contains(fraza))
            {
                return true;
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Publikacja>() 
            { 
                new Ksiazka("Quo Vadis", 1999, "Jan Kowalski", 200),
                new Czasopismo("Czasopis", 2000, 5, true, false),
                new Komiks("Marvel", 2015, "Jan Kowalski"),
            };

            Console.WriteLine("Podaj frazę");
            var fraza = Console.ReadLine();

            var newList = new List<Publikacja>();
            foreach (var item in lista)
            {
                if (item.Pasuje(fraza))
                {
                    newList.Add(item);
                }
            }

            if (newList.Count > 0)
            {
                Console.WriteLine("Wynik wyszukiwania");
                foreach (var item in newList)
                {
                    Console.WriteLine(item.Opis());
                }
            }
            else
            {
                Console.WriteLine("Nie znaleziono");
            }
        }
    }
}
