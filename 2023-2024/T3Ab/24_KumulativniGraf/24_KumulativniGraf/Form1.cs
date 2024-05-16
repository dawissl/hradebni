namespace _24_KumulativniGraf
{
    public partial class Form1 : Form
    {
        private const int DATA_SIZE = 25;
        private int[] data = new int[DATA_SIZE];
        private int[] cumulative = new int[DATA_SIZE];
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DATA_SIZE; i++)
                data[i] = (new Random().Next(0, 3) < 2) ? 0 : 1;

            int sum = 0;
            for(int i = 0; i < DATA_SIZE; i++)
            {
                sum += data[i];
                cumulative[i] = sum;
            }
            PanelGraf.Refresh();
        }

        private void PanelGraf_Paint(object sender, PaintEventArgs e)
        {
            Pen def = new Pen(Brushes.Blue, 2);
            Pen cumul = new Pen(Brushes.Red, 2);
            Point[] defP = new Point[DATA_SIZE];
            Point[] cumulP = new Point[DATA_SIZE];

            for (int i = 0; i < DATA_SIZE; i++)
            {
                defP[i] = new Point(i * 10, PanelGraf.Height - data[i] * 20-10);
                cumulP[i] = new Point(i * 10, PanelGraf.Height - cumulative[i] * 20-10); 
            }
            Graphics g = e.Graphics;
            g.DrawLines(def, defP);
            g.DrawLines(cumul, cumulP);
        }
    }
}