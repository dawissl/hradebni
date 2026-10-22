namespace _04_Katalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*lbOdmeny.Items.Add(new Polozka("a",10,"aaa"));
            lbOdmeny.Items.Add(new Polozka("b",1,"baaa"));
            lbOdmeny.Items.Add(new Polozka("c",0,"caaa"));
            lbOdmeny.Items.Add(new Polozka("d",8,"daaa"));*/
        }

        private void btnPridat_Click(object sender, EventArgs e)
        {
            using (DialogPolozka dp = new DialogPolozka())
            {
                if (dp.ShowDialog() == DialogResult.OK)
                {
                    Polozka novaPolozka = dp.Polozka;
                    lbOdmeny.Items.Add(novaPolozka);
                    KontrolaTlacitek();
                }
            }
        }

        private void KontrolaTlacitek()
        {
            if (lbOdmeny.Items.Count == 0)
            {
                btnSmazat.Enabled = false;
                btnUpravit.Enabled = false;
                btnVybrat.Enabled = false;
            }
            else
            {
                btnSmazat.Enabled = true;
                btnUpravit.Enabled = true;
                btnVybrat.Enabled = true;
            }

        }

        private void btnSmazat_Click(object sender, EventArgs e)
        {
            if(lbOdmeny.SelectedIndex != -1)
            {
                lbOdmeny.Items.RemoveAt(lbOdmeny.SelectedIndex);
            }
            else
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Není vybraná položka";
            }
        }
    }
}
