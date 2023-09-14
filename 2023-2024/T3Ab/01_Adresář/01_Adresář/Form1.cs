namespace _01_Adresář
{
    public partial class Form1 : Form
    {
        private List<Kontakt> adresar = new List<Kontakt>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPridani_Click(object sender, EventArgs e)
        {
            if(TxtTelefon.Text == "")
            {
                adresar.Add(new Kontakt(TxtJmeno.Text, TxtPrijmeni.Text, TxtMail.Text));
            }
            else
            {
                adresar.Add(new Kontakt(TxtJmeno.Text, TxtPrijmeni.Text, TxtMail.Text, TxtTelefon.Text));

            }
            LblCount.Text = $"{adresar.Count}";
        }

        private void BtnVyhledavat_Click(object sender, EventArgs e)
        {
            string vystup = $"Nalezené kontakty:{Environment.NewLine}";

            foreach(Kontakt k in adresar)
            {
                if(k.Surename == TxtVyhledavani.Text)
                {
                    vystup += $"{k}{Environment.NewLine}{Environment.NewLine}";
                }
            }
            MessageBox.Show(vystup);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            string vystup = $"Jmeno;Prijmeni;Email;Telefon{Environment.NewLine}";

            foreach (Kontakt k in adresar)
            {
                vystup += k.ToCsv() + Environment.NewLine; 
            }
            MessageBox.Show(vystup);
        }
    }
}