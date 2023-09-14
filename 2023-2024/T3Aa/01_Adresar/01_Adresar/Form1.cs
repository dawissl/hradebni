namespace _01_Adresar
{
    public partial class Form1 : Form
    {
        private List<Kontakt> adresar = new List<Kontakt>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPridejKontakt_Click(object sender, EventArgs e)
        {
            if(TxtTelefon.Text == "")
            {
                adresar.Add(new Kontakt(TxtJmeno.Text,TxtPrijmeni.Text,TxtMail.Text));
            }
            else
            {
                adresar.Add(new Kontakt(TxtJmeno.Text, TxtPrijmeni.Text, TxtMail.Text, TxtTelefon.Text));
            }
            LblCount.Text = $"{adresar.Count}";
        }

        private void BtnVyhledat_Click(object sender, EventArgs e)
        {
            string vystup = $"Nalezene kontakty:{Environment.NewLine}";
            foreach(Kontakt k in adresar)
            {
                if(k.Surname == TxtVyhledavac.Text)
                {
                    vystup += $"{k}{Environment.NewLine}";
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