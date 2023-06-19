using System.Net.Http.Headers;

namespace _12_GrafHodnot
{
    public partial class Form1 : Form
    {
        private List<int> obili = new List<int>();
        public Form1()
        {
            InitializeComponent();
            LoadFiles();
        }

        /// <summary>
        /// Nacti veskere soubor a hodnoty ulož do listu
        /// </summary>
        private void LoadFiles()
        {
            using (StreamReader sr = new StreamReader("wheat.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string cena = line.Split(";")[1];
                    obili.Add(int.Parse(cena.Split(",")[0]));
                }



                sr.Close();
            }
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            PanelGraf.Refresh();
        }

        private void PanelGraf_Paint(object sender, PaintEventArgs e)
        {
            Graphics grf = e.Graphics;

            if (CheckWheat.Checked)
            {
                Point[] obiliBody = new Point[obili.Count];

                for (int x = 0; x < obiliBody.Length; x++)
                {
                    obiliBody[x] = new Point(x, PanelGraf.Height - obili[x]);
                }

                grf.DrawLines(Pens.Red, obiliBody);
            }
        }
    }
}