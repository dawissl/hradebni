namespace _22_GrafCen
{
    public partial class Form1 : Form
    {
        private List<int> obili = new List<int>();
        private List<int> hovezi = new List<int>();
        public Form1()
        {
            InitializeComponent();
            LoadFiles();
        }

        private void LoadFiles()
        {
            using(StreamReader sr = new StreamReader("wheat.csv"))
            {
                // naprazdno vy�teme zahlav�, kter� nenese d�le�it� info
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
                // naprazdno vy�teme zahlav�, kter� nenese d�le�it� info
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
                List<Point> bodyObili = new List<Point>();
                for(int x = 0; x < obili.Count; x++)
                {
                    bodyObili.Add(new Point(x, PanelGraph.Height - obili[x]));
                }
                grf.DrawLines(Pens.Orange, bodyObili.ToArray());
            }

            if (CheckBeef.Checked)
            {
                Point[] bodyHovezi = new Point[hovezi.Count];
                for (int x = 0; x < bodyHovezi.Length; x++)
                {
                    bodyHovezi[x] = new Point(x, PanelGraph.Height - hovezi[x]);
                }
                grf.DrawLines(Pens.Red, bodyHovezi);
            }

        }
    }
}