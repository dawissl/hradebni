using System.Net.Http.Headers;

namespace _19_Ponorka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            new GeneratorSouboru("file.csv");
            AnalyzaDat analyza = new AnalyzaDat("file.csv");
            Point[] hloubka = new Point[analyza.Data.Count];
            Point[] tlak = new Point[analyza.Data.Count];

            for (int i = 0; i < analyza.Data.Count; i++)
            {
                hloubka[i] = new Point(analyza.Data[i].Cas * 5, analyza.Data[i].Hloubka);
                tlak[i] = new Point(analyza.Data[i].Cas * 5, analyza.Data[i].Tlak * 15);
            }

            Graphics g = e.Graphics;

            g.DrawLines(Pens.Red, hloubka);
            g.DrawLines(Pens.Blue, tlak);

            g.DrawLine(Pens.DeepPink, new Point(30*5,0), new Point(30*5,panel1.Height));
            g.DrawLine(Pens.DeepPink, new Point(40*5,0), new Point(40*5,panel1.Height));
            string vystup = analyza.AnalyzaIntervalu(30, 40);
            g.DrawString(vystup, new Font("Arial", 28), Brushes.Green, 10, 300);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
    }
}