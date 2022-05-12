namespace Target
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
            int size = 200;
            int step = 10;
            int halfstep = step / 2;

            SolidBrush color1 = new SolidBrush(LblCol1.BackColor);
            SolidBrush color2 = new SolidBrush(LblCol2.BackColor);

            g.FillRectangle(color2, 0, 0, size, size);
            g.FillRectangle(color1, 0 + halfstep, 0 + halfstep, size - step, size - step);

        }
    }
}