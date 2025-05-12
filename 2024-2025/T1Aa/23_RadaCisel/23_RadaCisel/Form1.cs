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
            if(mnozinaCisel == null)
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
            }


            LblVystup.Text = text;
        }

        private string MaxHodnota(int[] mnozinaCisel)
        {
            int max = mnozinaCisel[0];
            for (int i = 1; i < mnozinaCisel.Length; i++)
            {
                if (mnozinaCisel[i]>max)
                    max = mnozinaCisel[i];
            }
            return $"Nejvyšší hodnota je {max}";
        }

        private string SumaHodnot(int[] mnozinaCisel)
        {
            int soucet = 0;
            foreach(int cislo in mnozinaCisel)
            {
                soucet += cislo;
            }
            return $"Souèet hodnot je {soucet}";
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
