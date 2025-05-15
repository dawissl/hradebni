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
            // vytvo�en� pole substringu vznikle rozdelenim podle znaku ��rka
            string[] mnozina = TxtNumbers.Text.Split(',');
            mnozinaCisel = new int[mnozina.Length];
            // naplnen� pole mnozinaCisel hodnotami ziskanych z mnoziny
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
            // informace u�ivateli o na�ten� ��sel
            MessageBox.Show("��sla jsou na�tena");
        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            if(mnozinaCisel == null)
            {
                MessageBox.Show("Nebyla na�tena ��dn� ��sla");
                return;
            }
            string vystup = String.Empty;
            switch (ComboOpt.Text.ToUpper())
            {
                case "V�PIS":
                    vystup = VypisHodnot(mnozinaCisel);
                    break;
                case "MAXIMUM/MINIMUM":
                    vystup = NajdiMinMax(mnozinaCisel);
                    break;
                case "PO�ET SUD�CH/LICH�CH":
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
            return $"Sud�ch ��sel je {sude}, lich�ch ��sel je {liche}";
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
        /// Jednoduch� v�pis hodnot
        /// </summary>
        /// <param name="mnozinaCisel">pole ��sel k zobrazen�</param>
        /// <returns>textov� informace v�pisu</returns>
        private string VypisHodnot(int[] mnozinaCisel)
        {
            string tmp = "Na�ten� hodnoty jsou: ";
            foreach (int cislo in mnozinaCisel)
            {
                tmp += $"{cislo}, ";
            }
            return tmp;
        }
    }
}
