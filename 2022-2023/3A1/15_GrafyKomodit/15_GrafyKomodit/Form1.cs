using System.IO;
namespace _15_GrafyKomodit
{
    public partial class Form1 : Form
    {
        private List<int> wheatList = new List<int>();
        private List<int> beefList = new List<int>();
        private List<int> cooperList = new List<int>();


        public Form1()
        {
            InitializeComponent();
            LoadFiles();
        }

        /// <summary>
        /// Read files of goods, transfer data to according list of int
        /// </summary>
        private void LoadFiles()
        {
            // load and parse data of wheat
            using (StreamReader sr = new StreamReader("wheat.csv"))
            {
                //blank read of header
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string part = line.Split(';')[1];
                    wheatList.Add(int.Parse(part.Split(',')[0]));
                }
                sr.Close();
            }
            // load and parse data of beef

            using (StreamReader sr = new StreamReader("beef.csv"))
            {
                //blank read of header
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string part = line.Split(';')[1];
                    string number = part.Substring(0, 4);
                    //number = "1,235"

                    beefList.Add(Convert.ToInt32(double.Parse(number) * 75));

                }
                sr.Close();
            }
            // load and parse data of cooper
            using (StreamReader sr = new StreamReader("cooper.csv"))
            {
                //blank read of header
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string part = line.Split(';')[1];
                    string number = part.Substring(0, 4);
                    //number = "1123"

                    cooperList.Add(int.Parse(number) / 100);

                }
                sr.Close();
            }

        }

     
        // Draw graphs of data
        private void PanelGraf_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //prepare array for adding points
            Point[] points;

            if (CheckWheat.Checked)
            {
                points = new Point[wheatList.Count];
                for (int x = 0; x < wheatList.Count; x++)
                {
                    // true value should be displayed from botto of Panel
                    points[x] = new Point(x, PanelGraf.Height - wheatList[x]);
                }

                g.DrawLines(Pens.Orange,points);

                // count average and draw to graph
                int avg = Convert.ToInt32(wheatList.Average());
                g.DrawLine(Pens.Orange, new Point(0, PanelGraf.Height - avg), new Point(PanelGraf.Width,PanelGraf.Height - avg));
            }

            if (CheckBeef.Checked)
            {
                points = new Point[beefList.Count];
                for (int x = 0; x < beefList.Count; x++)
                {
                    points[x] = new Point(x, PanelGraf.Height - beefList[x]);
                }
                g.DrawLines(Pens.Green, points);

                // count average and draw to graph
                int avg = Convert.ToInt32(beefList.Average());
                g.DrawLine(Pens.Green, new Point(0, PanelGraf.Height - avg), new Point(PanelGraf.Width, PanelGraf.Height - avg));

            }

            if (CheckCooper.Checked)
            {
                points = new Point[cooperList.Count];
                for (int x = 0; x < cooperList.Count; x++)
                {
                    points[x] = new Point(x, PanelGraf.Height - cooperList[x]);
                }
                g.DrawLines(Pens.Red, points);

                // count average and draw to graph
                int avg = Convert.ToInt32(cooperList.Average());
                g.DrawLine(Pens.Red, new Point(0, PanelGraf.Height - avg), new Point(PanelGraf.Width, PanelGraf.Height - avg));

            }

        }

        private void CheckWheat_CheckedChanged(object sender, EventArgs e)
        {
            PanelGraf.Refresh();
        }

        private void CheckBeef_CheckedChanged(object sender, EventArgs e)
        {
            PanelGraf.Refresh();
        }

        private void CheckCooper_CheckedChanged(object sender, EventArgs e)
        {
            PanelGraf.Refresh();
        }
    }
}