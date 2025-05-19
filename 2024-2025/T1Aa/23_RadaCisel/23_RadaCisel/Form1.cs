using Accessibility;

namespace _23_RadaCisel
{
    public partial class Form1 : Form
    {
        int[] mnozinaCisel;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            string[] mnozina = TxtNumbers.Text.Split(',');
            mnozinaCisel = new int[mnozina.Length];

            for (int i = 0; i < mnozina.Length; i++)
            {
                mnozinaCisel[i] = int.Parse(mnozina[i]);
            }
            MessageBox.Show("Èísla naètena");

        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            string text = "";
            if (mnozinaCisel == null)
            {
                MessageBox.Show("Nejprve je tøeba vložit hodnoty!");
                return;
            }
            switch (ComboOpt.Text.ToUpper())
            {
                case "VÝPIS":
                    text = VypisHodnot(mnozinaCisel);
                    break;
                case "SUMA":
                    text = SumaHodnot(mnozinaCisel);
                    break;
                case "MAXIMUM":
                    text = MaxHodnota(mnozinaCisel);
                    break;
                case "SUDÁ/LICHÁ":
                    text = SudaLicha(mnozinaCisel);
                    break;
            }


            LblVystup.Text = text;
        }

        private string SudaLicha(int[] mnozinaCisel)
        {
            int suda = 0, licha = 0;
            for (int i = 0; i < mnozinaCisel.Length; i++)
            {
                if (mnozinaCisel[i] % 2 == 0)
                    suda++;
                else
                    licha++;
            }
            return $"Sudých èísel je {suda} a lichých èísel je {licha}";
        }

        private string MaxHodnota(int[] mnozinaCisel)
        {
            int max = mnozinaCisel[0];
            for (int i = 1; i < mnozinaCisel.Length; i++)
            {
                // využití ternárního operátoru
                max = max < mnozinaCisel[i] ? mnozinaCisel[i] : max;
            }
            return $"Maximum je: {max}";
        }

        private string SumaHodnot(int[] mnozinaCisel)
        {
            int suma = 0;

            for (int i = mnozinaCisel.Length - 1; i >= 0; i--)
            {
                suma = suma + mnozinaCisel[i];

                // suma += mnozinaCisel[i];
            }
            // $ = alt + 36
            return $"Souèet hodnot je: {suma}";
        }

        private string VypisHodnot(int[] mnozinaCisel)
        {
            string tmp = "Naètené hodnoty jsou: ";
            foreach (int item in mnozinaCisel)
            {
                tmp += $"{item}, ";
            }
            return tmp;
        }
    }
}
