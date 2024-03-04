namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point[] podvaha = { new Point(15, panel1.Height - 15), new Point(panel1.Width - 15, panel1.Height - 15), new Point(panel1.Width - 15, panel1.Height - 200) };
            g.FillPolygon(Brushes.Blue, podvaha);
            Point[] normal = { new Point(15, panel1.Height - 15), new Point(panel1.Width - 15, panel1.Height - 15), new Point(panel1.Width - 15, panel1.Height - 200) };

            g.DrawLine(new Pen(Color.Black, 3f), 15, 15, 15, panel1.Height - 15);
            g.DrawLine(new Pen(Color.Black, 3f), 15, panel1.Height - 15, panel1.Width - 15, panel1.Height - 15);

            g.RotateTransform(30);
            g.DrawString("ABC",new Font("Arial",16),Brushes.Green,50,50);
            g.ResetTransform();
            g.DrawString("ABC", new Font("Arial", 16), Brushes.Red, 80, 50);
        }
    }
}