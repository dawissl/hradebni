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
            // rozdìlení množiny èísel v podobì string podle èárky
            string[] mnozina = TxtNumbers.Text.Split(',');
            mnozinaCisel = new int[mnozina.Length];
            // pøevedení èísel ze string na int
            for (int i = 0; i < mnozina.Length; i++)
            {
                try
                {
                    mnozinaCisel[i] = int.Parse(mnozina[i]);
                }
                catch (FormatException ex)
                {
                    LblVystup.Text = ex.Message;
                    return;
                }
            }
            MessageBox.Show("Èísla jsou naètena");
        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            // ovìøení, zda je množina naplnìna daty
            if(mnozinaCisel == null)
            {
                LblVystup.Text = "Nebyla zadana vstupní èísla";
                TxtNumbers.Text = "";
                return;
            }
            // vybìr operace pro naètené hodnoty èísel
            string vystup = "";
            switch (ComboOpt.Text.ToUpper())
            {
                case "VÝPIS":
                    vystup = VypisHodnot(mnozinaCisel);
                    break;
                case "SUMA":
                    vystup = SoucetHodnot(mnozinaCisel);
                    break;

            }
            LblVystup.Text = vystup;
        }

        private string SoucetHodnot(int[] mnozinaCisel)
        {
            return $"Souèet èísel je: {mnozinaCisel.Sum()}";
        }

        private string VypisHodnot(int[] mnozinaCisel)
        {
            string text = "Naètené hodnoty jsou: ";

            foreach (int cislo in mnozinaCisel)
            {
                text += $"{cislo}, ";
            }
            return text;
        }
    }
}
