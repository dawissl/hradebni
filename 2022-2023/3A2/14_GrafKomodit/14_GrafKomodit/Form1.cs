namespace _14_GrafKomodit
{
    public partial class Form1 : Form
    {
        private List<int> listObili = new List<int>();
        private List<int> listHovezi = new List<int>();
        private List<int> listMed = new List<int>();


        public Form1()
        {
            InitializeComponent();
            LoadFiles();
        }

        private void LoadFiles()
        {
            using (StreamReader sr = new StreamReader("wheat.csv"))
            {

                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // 1990-01-01;167,918579101563
                    string cena = line.Split(';')[1].Split(',')[0];
                    //167
                    listObili.Add(int.Parse(cena));
                }
                sr.Close();
            }

            using (StreamReader sr = new StreamReader("beef.csv"))
            {

                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // 1984-02-01;1,340
                    string cena = line.Split(';')[1].Substring(0, 4);
                    //1,340
                    listHovezi.Add(Convert.ToInt32(double.Parse(cena) * 50));
                }
                sr.Close();
            }

            using (StreamReader sr = new StreamReader("cooper.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // 1990 - 01 - 01; 2365,55699088135
                    string cena = line.Split(';')[1].Substring(0, 4);
                    //2356
                    listMed.Add(int.Parse(cena) / 50);
                }
                sr.Close();
            }




        }

        private void PanelGraph_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            DrawAxes(g);
            Point[] bodyGrafu;
            if (CheckWheat.Checked)
            {
                bodyGrafu = new Point[listObili.Count];
                for (int x = 0; x < listObili.Count; x++)
                {
                    bodyGrafu[x] = new Point(x, PanelGraph.Height - listObili[x]);
                }
                g.DrawLines(Pens.Orange, bodyGrafu);

                int avg = Convert.ToInt32(listObili.Average());
                g.DrawLine(Pens.Orange, 0, PanelGraph.Height - avg,
                        PanelGraph.Width, PanelGraph.Height - avg);
            }

            if (CheckBeef.Checked)
            {
                bodyGrafu = new Point[listHovezi.Count];
                for (int x = 0; x < listHovezi.Count; x++)
                {
                    bodyGrafu[x] = new Point(x, PanelGraph.Height - listHovezi[x]);
                }

                g.DrawLines(Pens.Red, bodyGrafu);



                int avg = Convert.ToInt32(listHovezi.Average());
                g.DrawLine(Pens.Red, 0, PanelGraph.Height - avg,
                        PanelGraph.Width, PanelGraph.Height - avg);
            }

            if (CheckCooper.Checked)
            {
                bodyGrafu = new Point[listMed.Count];
                for (int x = 0; x < listMed.Count; x++)
                {
                    bodyGrafu[x] = new Point(x, PanelGraph.Height - listMed[x]);
                }
                g.DrawLines(Pens.Blue, bodyGrafu);

                int avg = Convert.ToInt32(listMed.Average());
                g.DrawLine(Pens.Blue, 0, PanelGraph.Height - avg,
                        PanelGraph.Width, PanelGraph.Height - avg);
            }

        }

        private void DrawAxes(Graphics g)
        {
            int axeX = PanelGraph.Height -50;
            g.DrawLine(Pens.Black, 0, axeX, PanelGraph.Width, axeX);
            int year = 1990;
            // skoke je po 70 mesicich -> 5 letech
            for(int x=0;x<PanelGraph.Width; x += 70)
            {
                g.DrawLine(Pens.Black, x, axeX - 5, x, axeX + 5);
                g.DrawString($"{year}",new Font("Arial",12),Brushes.Black,new Point(x, axeX+10));
                year += 5;
            }

        }

        private void CheckWheat_CheckedChanged(object sender, EventArgs e)
        {
            PanelGraph.Refresh();
        }

        private void CheckBeef_CheckedChanged(object sender, EventArgs e)
        {
            PanelGraph.Refresh();
        }

        private void CheckCooper_CheckedChanged(object sender, EventArgs e)
        {
            PanelGraph.Refresh();
        }
    }
}