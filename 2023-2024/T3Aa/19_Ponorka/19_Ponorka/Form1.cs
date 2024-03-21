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
            new GeneratorDat("data.csv");
            AnalyzatorDat a = new AnalyzatorDat("data.csv");
            Point[] hloubka = new Point[a.Data.Count];
            Point[] tlak = new Point[a.Data.Count];

            for (int i = 0; i < a.Data.Count; i++)
            {
                hloubka[i] = new Point(a.Data[i].Cas*5, a.Data[i].Hloubka);
                tlak[i] = new Point(a.Data[i].Cas*5, a.Data[i].Tlak * 15);
            }
            Graphics g = e.Graphics;
            g.DrawLines(Pens.Red, hloubka);
            g.DrawLines(Pens.Blue, tlak);
        }
    }
}
