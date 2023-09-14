namespace _01_Adersar
{
    public partial class Form1 : Form
    {
        private List<Kontakt> adresar = new List<Kontakt>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(TxtTelefon.Text == "")
            {
                adresar.Add(new Kontakt(TxtJmeno.Text,TxtPrijmeni.Text,TxtEmail.Text));
            }
            else
            {
                adresar.Add(new Kontakt(TxtJmeno.Text, TxtPrijmeni.Text, TxtEmail.Text, TxtTelefon.Text));

            }
            LblCount.Text = $"{adresar.Count}";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string vystup = $"Nalezene kontakty:{Environment.NewLine}";

            foreach(Kontakt kontakt in adresar)
            {
                if(kontakt.Surname == TxtVyhledavani.Text)
                {
                    vystup += kontakt + Environment.NewLine;    
                }
            }

            MessageBox.Show(vystup);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            string vystup = $"Jmeno;Prijmeni;Email;Telefon{Environment.NewLine}";

            foreach (Kontakt kontakt in adresar)
            {
                    vystup += kontakt.ToCsv() + Environment.NewLine;                
            }

            MessageBox.Show(vystup);
        }
    }
}