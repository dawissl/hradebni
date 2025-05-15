namespace _20_CiselnaRada
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
            // vytvoøení pole substringu vznikle rozdelenim podle znaku èárka
            string[] mnozina = TxtNumbers.Text.Split(',');
            mnozinaCisel = new int[mnozina.Length];
            // naplnení pole mnozinaCisel hodnotami ziskanych z mnoziny
            for (int i = 0; i < mnozina.Length; i++)
            {
                try
                {
                    mnozinaCisel[i] = int.Parse(mnozina[i]);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                    mnozinaCisel = null;  
                    return;
                }
            }
            // informace uživateli o naètení èísel
            MessageBox.Show("Èísla jsou naètena");
        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            if(mnozinaCisel == null)
            {
                MessageBox.Show("Nebyla naètena žádná èísla");
                return;
            }
            string vystup = String.Empty;
            switch (ComboOpt.Text.ToUpper())
            {
                case "VÝPIS":
                    vystup = VypisHodnot(mnozinaCisel);
                    break;
                case "MAXIMUM/MINIMUM":
                    vystup = NajdiMinMax(mnozinaCisel);
                    break;
                case "POÈET SUDÝCH/LICHÝCH":
                    vystup = SudeLiche(mnozinaCisel);
                    break;
            }
            LblVystup.Text = vystup;
        }

        private string SudeLiche(int[] mnozinaCisel)
        {
            int sude = 0, liche = 0;
            foreach (int x in mnozinaCisel)
            {
                if (x % 2 == 0)
                    sude++;
                else
                    liche++;
            }
            return $"Sudých èísel je {sude}, lichých èísel je {liche}";
        }

        private string NajdiMinMax(int[] mnozinaCisel)
        {
            string tmp = "Maximum je ";
            int min = mnozinaCisel[0];
            int max = mnozinaCisel[0];

            for (int i = 1; i < mnozinaCisel.Length; i++)
            {
                if (max < mnozinaCisel[i])
                    max = mnozinaCisel[i];
                if (min > mnozinaCisel[i])
                    min = mnozinaCisel[i];
            }

            tmp += $"minimum je {min}";
            return tmp;
        }

        /// <summary>
        /// Jednoduchý výpis hodnot
        /// </summary>
        /// <param name="mnozinaCisel">pole èísel k zobrazení</param>
        /// <returns>textová informace výpisu</returns>
        private string VypisHodnot(int[] mnozinaCisel)
        {
            string tmp = "Naètené hodnoty jsou: ";
            foreach (int cislo in mnozinaCisel)
            {
                tmp += $"{cislo}, ";
            }
            return tmp;
        }
    }
}
