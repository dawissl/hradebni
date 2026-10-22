namespace _04_Katalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPridat_Click(object sender, EventArgs e)
        {
            using(DialogPolozka dp = new DialogPolozka())
            {
                if(dp.ShowDialog() == DialogResult.OK)
                {
                    lbOdmeny.Items.Add(dp.P);
                }
            }
            KontrolaTlacitek();
        }

        private void KontrolaTlacitek()
        {
            if(lbOdmeny.Items.Count == 0)
            {
                btnSmazat.Enabled = false;
                btnVybrat.Enabled = false;
                btnUpravit.Enabled = false;
            }
            else
            {
                btnSmazat.Enabled = true;
                btnVybrat.Enabled = true;
                btnUpravit.Enabled = true;
            }

        }
    }
}
