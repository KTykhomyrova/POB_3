namespace powtorzenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var suma = 0;
            var wynik = "Wybrane us³ugi:\n";
            var num = 0;
            foreach (var item in checkedListBox.CheckedItems)
            {
                num++;
                if (item.ToString() == "Wymiana oleju")
                {
                    suma += 300;
                    wynik += $"{num}. Wymiana oleju\n";
                }

                if (item.ToString() == "Zmiana opon")
                {
                    suma += 100;
                    wynik += $"{num}. Zmiana opon\n";
                }

                if (item.ToString() == "Wymiana klocków hamulcowych")
                {
                    suma += 400;
                    wynik += $"{num}. Wymiana klocków hamulcowych\n";
                }

                if (item.ToString() == "Sprawdzenie klimatyzacji")
                {
                    suma += 120;
                    wynik += $"{num}. Sprawdzenie klimatyzacji\n";
                }

                if (item.ToString() == "Diagnostyka komputerowa")
                {
                    suma += 90;
                    wynik += $"{num}. Diagnostyka komputerowa\n";
                }
            }

            if (suma == 0)
            {
                MessageBox.Show("Musisz wybra minimum 1 opcjê", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                wynik += $"³¹czny koszt us³ugi: {suma}";

                richTextBox.Text = wynik.ToString();
            }   
        }
    }
}
