namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<SnowFlake> snowFlakes = new List<SnowFlake>();
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (SnowFlake flake in snowFlakes)
            {
                g.FillEllipse(Brushes.White, flake.X, flake.Y, 10, 10);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rnd.Next(0, 10) < 3)
            {
                snowFlakes.Add(new SnowFlake(rnd.Next(5, panel1.Width - 4), 0));
            }
            for (int i = 0; i < snowFlakes.Count; i++)
            {
                if (snowFlakes[i].Y > panel1.Height)
                    snowFlakes.RemoveAt(i);
                else
                    snowFlakes[i].Y += 5;
            }
            panel1.Refresh();
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