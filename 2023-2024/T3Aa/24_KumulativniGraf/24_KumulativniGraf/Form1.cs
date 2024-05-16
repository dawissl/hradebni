namespace _24_KumulativniGraf
{
    public partial class Form1 : Form
    {
        private List<int> data = new List<int>();
        private const int DATA_SIZE = 20;
        private int[] cumulative = new int[DATA_SIZE];
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            data = new List<int>();
            for (int i = 0; i < DATA_SIZE; i++)
                data.Add((new Random().Next(0, 100) <= 40) ? 0 : 1);
            int sum = 0;
            for (int i = 0; i < DATA_SIZE; i++)
            {
                sum += data[i];
                cumulative[i] = sum;
            }
            PanelGraph.Refresh();
        }

        private void PanelGraph_Paint(object sender, PaintEventArgs e)
        {
            if (data.Count == 0) return;

            Graphics g = e.Graphics;

            Point[] points = new Point[DATA_SIZE];
            
            for (int i = 0; i < DATA_SIZE; i++)
            {
                points[i] = new Point(i*20, PanelGraph.Height - cumulative[i] * 10);
            }
            g.DrawLines(new Pen(Brushes.Blue, 2), points);
        }
    }
}
