namespace zad1
{
    public enum CardColor
    {
        Red,
        Black
    }

    class Card
    {
        public Card(int value, CardColor color, string type, string cardName)
        {
            Value = value;
            Color = color;
            Type = type;
            CardName = cardName;
        }

        public int Value { get; set; }
        public CardColor Color { get; set; }
        public string Type { get; set; }
        public string CardName { get; set; }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            var deck = new List<Card>
            {   new Card(2, CardColor.Black, "pik", "2"),
                new Card(3, CardColor.Black, "pik", "3"),
                new Card(4, CardColor.Black, "pik", "4"),
                new Card(5, CardColor.Black, "pik", "5"),
                new Card(6, CardColor.Black, "pik", "6"),
                new Card(7, CardColor.Black, "pik", "7"),
                new Card(8, CardColor.Black, "pik", "8"),
                new Card(9, CardColor.Black, "pik", "9"),
                new Card(10, CardColor.Black, "pik", "10"),
                new Card(11, CardColor.Black, "pik", "J"),
                new Card(12, CardColor.Black, "pik", "Q"),
                new Card(13, CardColor.Black, "pik", "K"),
                new Card(14, CardColor.Black, "pik", "A"),

                new Card(2, CardColor.Black, "trefl", "2"),
                new Card(3, CardColor.Black, "trefl", "3"),
                new Card(4, CardColor.Black, "trefl", "4"),
                new Card(5, CardColor.Black, "trefl", "5"),
                new Card(6, CardColor.Black, "trefl", "6"),
                new Card(7, CardColor.Black, "trefl", "7"),
                new Card(8, CardColor.Black, "trefl", "8"),
                new Card(9, CardColor.Black, "trefl", "9"),
                new Card(10, CardColor.Black, "trefl", "10"),
                new Card(11, CardColor.Black, "trefl", "J"),
                new Card(12, CardColor.Black, "trefl", "Q"),
                new Card(13, CardColor.Black, "trefl", "K"),
                new Card(14, CardColor.Black, "trefl", "A"),

                new Card(2, CardColor.Red, "karo", "2"),
                new Card(3, CardColor.Red, "karo", "3"),
                new Card(4, CardColor.Red, "karo", "4"),
                new Card(5, CardColor.Red, "karo", "5"),
                new Card(6, CardColor.Red, "karo", "6"),
                new Card(7, CardColor.Red, "karo", "7"),
                new Card(8, CardColor.Red, "karo", "8"),
                new Card(9, CardColor.Red, "karo", "9"),
                new Card(10, CardColor.Red, "karo", "10"),
                new Card(11, CardColor.Red, "karo", "J"),
                new Card(12, CardColor.Red, "karo", "Q"),
                new Card(13, CardColor.Red, "karo", "K"),
                new Card(14, CardColor.Red, "karo", "A"),

                new Card(2, CardColor.Red, "kier", "2"),
                new Card(3, CardColor.Red, "kier", "3"),
                new Card(4, CardColor.Red, "kier", "4"),
                new Card(5, CardColor.Red, "kier", "5"),
                new Card(6, CardColor.Red, "kier", "6"),
                new Card(7, CardColor.Red, "kier", "7"),
                new Card(8, CardColor.Red, "kier", "8"),
                new Card(9, CardColor.Red, "kier", "9"),
                new Card(10, CardColor.Red, "kier", "10"),
                new Card(11, CardColor.Red, "kier", "J"),
                new Card(12, CardColor.Red, "kier", "Q"),
                new Card(13, CardColor.Red, "kier", "K"),
                new Card(14, CardColor.Red, "kier", "A"),
            };


        }
    }
}
