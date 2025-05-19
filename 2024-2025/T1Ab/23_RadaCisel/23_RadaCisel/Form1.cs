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
            // rozd�len� mno�iny ��sel v podob� string podle ��rky
            string[] mnozina = TxtNumbers.Text.Split(',');
            mnozinaCisel = new int[mnozina.Length];
            // p�eveden� ��sel ze string na int
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
            MessageBox.Show("��sla jsou na�tena");
        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            // ov��en�, zda je mno�ina napln�na daty
            if (mnozinaCisel == null)
            {
                LblVystup.Text = "Nebyla zadana vstupn� ��sla";
                TxtNumbers.Text = "";
                return;
            }
            // vyb�r operace pro na�ten� hodnoty ��sel
            string vystup = "";
            switch (ComboOpt.Text.ToUpper())
            {
                case "V�PIS":
                    vystup = VypisHodnot(mnozinaCisel);
                    break;
                case "SUMA":
                    vystup = SoucetHodnot(mnozinaCisel);
                    break;
                case "MAX/MIN":
                    vystup = MaxMin(mnozinaCisel);
                    break;
                case "SUD�/LICH�":
                    vystup = SudaLicha(mnozinaCisel);
                    break;

            }
            LblVystup.Text = vystup;
        }

        private string SudaLicha(int[] mnozinaCisel)
        {
            int suda = 0, licha = 0;
            foreach (int x in mnozinaCisel)
            {
                if (x % 2 == 0)
                    suda++;
                else
                    licha++;
            }
            return $"V mno�in� je {suda} sud�ch a {licha} lich�ch ��sel.";
        }

        private string MaxMin(int[] mnozinaCisel)
        {
            int max = mnozinaCisel[0];
            int min = mnozinaCisel[0];
            for (int i = 1; i < mnozinaCisel.Length; i++)
            {
                // vyu�it� tern�r�ho oper�toru nam�sto if
                max = max < mnozinaCisel[i] ? mnozinaCisel[i] : max;
                min = min > mnozinaCisel[i] ? mnozinaCisel[i] : min;
            }
            return $"Maximum je: {max} a minimum je: {min}";
        }

        private string SoucetHodnot(int[] mnozinaCisel)
        {
            int tmp = 0;
            //for (int i = 0; i < mnozinaCisel.Length; i++) { }
            for (int i = mnozinaCisel.Length - 1; i >= 0; i--)
            {
                // tmp += mnozinaCisla[i]
                tmp = tmp + mnozinaCisel[i];
            }
            // $ = alt + 36
            return $"Sou�et hodnot je: {tmp}";
        }

        private string VypisHodnot(int[] mnozinaCisel)
        {
            string text = "Na�ten� hodnoty jsou: ";

            foreach (int cislo in mnozinaCisel)
            {
                text += $"{cislo}, ";
            }
            return text;
        }
    }
}
