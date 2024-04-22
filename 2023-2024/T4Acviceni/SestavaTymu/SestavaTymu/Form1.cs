using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace SestavaTymu
{
    public partial class Form1 : Form
    {
        private List<Hrac> soupiska;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateTeam ct = new CreateTeam(20);

            Random rnd = new Random();
            soupiska = new List<Hrac>();
            lblDefault.Text = "";
            lblSorted.Text = "";

            for (int i = 1; i <= 10; i++)
            {
                FieldPosition fp = FieldPosition.GOALKEEPER;
                switch (rnd.Next(0, 3))
                {
                    case 0: fp = FieldPosition.GOALKEEPER; break;
                    case 1: fp = FieldPosition.STRIKER; break;
                    case 2: fp = FieldPosition.DEFENDER; break;
                }
                soupiska.Add(
                    new Hrac(rnd.Next().ToString(),
                    fp, i, rnd.Next(10, 51), rnd.Next(10, 51), rnd.Next(10, 51)));
            }

            string s1 = "";
            foreach (Hrac h in soupiska)
            {
                s1 += h.ToString() + Environment.NewLine;
            }

            soupiska.Sort();

            string s2 = "";
            foreach (Hrac h in soupiska)
            {
                s2 += h.ToString() + Environment.NewLine;
            }
            lblDefault.Text = s1;
            lblSorted.Text = s2;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Hrac> sestava = new List<Hrac>();
            int utocnici = 0;
            int obranci = 0;
            int golmani = 1;
            if (Rad131.Checked)
            {
                utocnici = 1;
                obranci = 3;
            }
            if (Rad221.Checked)
            {
                utocnici = 2;
                obranci = 2;
            }
            if (Rad311.Checked)
            {
                utocnici = 3;
                obranci = 1;
            }
            foreach (Hrac h in soupiska)
            {
                if (utocnici > 0 && h.Position == FieldPosition.STRIKER)
                {
                    sestava.Add(h);
                    utocnici--;
                    continue;
                }
                if (obranci > 0 && h.Position == FieldPosition.DEFENDER)
                {
                    sestava.Add(h);
                    obranci--;
                    continue;
                }
                if (golmani > 0 && h.Position == FieldPosition.GOALKEEPER)
                {
                    sestava.Add(h);
                    golmani--;
                    continue;
                }
            }
            sestava.Sort();
            string sestavaTymu = "";
            foreach (Hrac h in sestava)
            {
                sestavaTymu += h.ToString() + Environment.NewLine;
            }
            lblSorted.Text = sestavaTymu;
            PanelTeam.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateTeam ct = new CreateTeam(20);

            Random rnd = new Random();
            soupiska = ct.LoadFile();
            lblDefault.Text = "";
            lblSorted.Text = "";
            string s1 = "";
            foreach (Hrac h in soupiska)
            {
                s1 += h.ToString() + Environment.NewLine;
            }

            soupiska.Sort();

            string s2 = "";
            foreach (Hrac h in soupiska)
            {
                s2 += h.ToString() + Environment.NewLine;
            }
            lblDefault.Text = s1;
            lblSorted.Text = s2;

        }

        private void PanelTeam_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int xAttack = 20;
            int xDefense = 120;
            int xGoalie = 220;

            int yRW = 20;
            int yLW = 200;
            int yCenter = 105;
            int yR = 50;
            int yL = 155;
            int size = 40;
            // TODO add jersey number and captain badge for elite player
            if (Rad131.Checked)
            {
                //ATTACK
                g.FillEllipse(Brushes.Red, xAttack, yCenter, size, size);
                // DEFENSE
                g.FillEllipse(Brushes.Yellow, xDefense, yRW, size, size);
                g.FillEllipse(Brushes.Yellow, xDefense, yLW, size, size);
                g.FillEllipse(Brushes.Yellow, xDefense, yCenter, size, size);
                // GOALKEEPER
                g.FillEllipse(Brushes.Green, xGoalie, yCenter, size, size);

            }
            if (Rad221.Checked)
            {
                g.FillEllipse(Brushes.Red, xAttack, yL, size, size);
                g.FillEllipse(Brushes.Red, xAttack, yR, size, size);
                g.FillEllipse(Brushes.Yellow, xDefense, yR, size, size);
                g.FillEllipse(Brushes.Yellow, xDefense, yL, size, size);
                g.FillEllipse(Brushes.Green, xGoalie, yCenter, size, size);

            }
            if (Rad311.Checked)
            {
                g.FillEllipse(Brushes.Red, xAttack, yRW, size, size);
                g.FillEllipse(Brushes.Red, xAttack, yLW, size, size);
                g.FillEllipse(Brushes.Red, xAttack, yCenter, size, size);
                g.FillEllipse(Brushes.Green, xGoalie, yCenter, size, size);
                g.FillEllipse(Brushes.Yellow, xDefense, yCenter, size, size);

            }
        }
    }
}