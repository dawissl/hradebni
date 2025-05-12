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
            if(mnozinaCisel == null)
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

            }
            LblVystup.Text = vystup;
        }

        private string SoucetHodnot(int[] mnozinaCisel)
        {
            return $"Sou�et ��sel je: {mnozinaCisel.Sum()}";
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
