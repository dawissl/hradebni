namespace _01_Adresar
{
    public partial class Form1 : Form
    {
        private List<Kontakt> adresar = new List<Kontakt>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPridat_Click(object sender, EventArgs e)
        {
            if(TxtTelefon.Text == "")
            {
                adresar.Add(
                    new Kontakt(TxtJmeno.Text,
                    TxtPrijmeni.Text,
                    TxtEmail.Text));
            }
            else
            {
                adresar.Add(
                    new Kontakt(TxtJmeno.Text,
                    TxtPrijmeni.Text, TxtEmail.Text,
                    TxtTelefon.Text));
            }

            LblCount.Text = $"{adresar.Count}";
        }

        private void BtnHledat_Click(object sender, EventArgs e)
        {
            string vystup = $"Nalezene kontakty:{Environment.NewLine}";

            foreach(Kontakt t in adresar)
            {
                if(t.Surename == TxtVyhledavac.Text)
                {
                    vystup += $"{t}{Environment.NewLine}{Environment.NewLine}";
                }
            }
            MessageBox.Show(vystup);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            string vystup = $"Jmeno;Prijmeni;Email;Telefon{Environment.NewLine}";

            foreach (Kontakt t in adresar)
            {
                vystup += $"{t.ToCsv()}{Environment.NewLine}";
            }
            MessageBox.Show(vystup);
        }
    }
}