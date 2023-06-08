namespace _22_GrafCen
{
    public partial class Form1 : Form
    {
        private List<int> obili = new List<int>();
        private List<int> hovezi = new List<int>();
        private List<int> med = new List<int>();

        const int BEEF_CONST = 15;
        const int COOPER_CONST = 50;
        public Form1()
        {
            InitializeComponent();
            LoadFiles();
        }

        private void LoadFiles()
        {
            using (StreamReader sr = new StreamReader("wheat.csv"))
            {
                // naprazdno vyèteme zahlaví, které nenese dùležité info
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // 1990-01-01;98.46874
                    string cena = line.Split(';')[1];

                    obili.Add(int.Parse(cena.Split('.')[0]));

                }
                sr.Close();
            }

            using (StreamReader sr = new StreamReader("beef.csv"))
            {
                // naprazdno vyèteme zahlaví, které nenese dùležité info
                sr.ReadLine();
                int row = 1;
                while (!sr.EndOfStream)
                {
             
                        string line = sr.ReadLine();
                        row++;
                        // 1990-01-01;98.46874
                        string cena = line.Split(';')[1];


                        hovezi.Add(Convert.ToInt32((double.Parse(cena.Substring(0,4).Replace(".",",")) * BEEF_CONST)));
          
                }
                sr.Close();
            }

            using (StreamReader sr = new StreamReader("cooper.csv"))
            {
                // naprazdno vyèteme zahlaví, které nenese dùležité info
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // 1990-01-01;98.46874
                    string cena = line.Split(';')[1];

                    med.Add(int.Parse(cena.Split('.')[0]) / COOPER_CONST);

                }
                sr.Close();
            }
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            PanelGraph.Refresh();
        }

        private void PanelGraph_Paint(object sender, PaintEventArgs e)
        {
            Graphics grf = e.Graphics;
            if (CheckWheat.Checked)
            {
                List<Point> graf = new List<Point>();
                for (int x = 0; x < obili.Count; x++)
                {
                    graf.Add(new Point(x, PanelGraph.Height - obili[x]));
                }
                grf.DrawLines(Pens.Orange, graf.ToArray());

            }

            if (checkBox1.Checked)
            {
                Point[] bodyHovezi = new Point[hovezi.Count];
                for(int x = 0; x < bodyHovezi.Length; x++)
                {
                    bodyHovezi[x] = new Point(x, PanelGraph.Height - hovezi[x]);
                }

                grf.DrawLines(Pens.Red, bodyHovezi);
            }

            if (CheckCooper.Checked)
            {
                Point[] bodyMed = new Point[med.Count];
                for (int x = 0; x < bodyMed.Length; x++)
                {
                    bodyMed[x] = new Point(x, PanelGraph.Height - med[x]);
                }

                grf.DrawLines(Pens.OrangeRed, bodyMed);
            }
        }
    }
}