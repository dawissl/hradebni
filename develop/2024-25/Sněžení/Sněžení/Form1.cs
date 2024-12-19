namespace Sněžení
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<SnowFlake> snowFlakes = new List<SnowFlake>();
        public Form1()
        {
            InitializeComponent();
        }

        private void PanelSky_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (SnowFlake flake in snowFlakes)
            {
                g.FillEllipse(Brushes.White, flake.X, flake.Y, 5, 5);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rnd.Next(0, 10) < 3)
            {
                snowFlakes.Add(new SnowFlake(rnd.Next(5, PanelSky.Width - 4), 0));
            }
            for(int i=0;i<snowFlakes.Count;i++)
            {
                if (snowFlakes[i].Y > PanelSky.Height)
                    snowFlakes.RemoveAt(i);
                else
                    snowFlakes[i].Y += 5;
            }
            PanelSky.Refresh();

        }
    }
    class SnowFlake
    {
        public int X { get; set; }
        public int Y { get; set; }
        public SnowFlake(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
