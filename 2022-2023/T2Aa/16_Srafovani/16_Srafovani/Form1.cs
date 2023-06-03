namespace _16_Srafovani
{
    public partial class Form1 : Form
    {
        private Brush background = new SolidBrush(Color.Blue);
        private Pen foreground = new Pen(Color.Yellow);
        public Form1()
        {
            InitializeComponent();
            LblBackground.BackColor = Color.Blue;
            LblForeground.BackColor = Color.Yellow;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(background, 0, 0, 200, 200);
     
            int step = 10;
            for(int i = 200; i >= 0; i -= step)
            {
                g.DrawLine(foreground, new Point(200 - i, 0), new Point(0, 200 - i));
            }

            for (int i = 0; i <=200; i += step)
            {
                g.DrawLine(foreground, new Point(200 ,i ), new Point(i, 200 ));
            }
        }

        private void LblBackground_Click(object sender, EventArgs e)
        {
            if (ClrDialog.ShowDialog() == DialogResult.OK)
            {
                LblBackground.BackColor = ClrDialog.Color;
                background = new SolidBrush(ClrDialog.Color);
                panel1.Refresh();
            }
        }

        private void LblForeground_Click(object sender, EventArgs e)
        {
            if (ClrDialog.ShowDialog() == DialogResult.OK)
            {
                LblForeground.BackColor = ClrDialog.Color;
                foreground = new Pen(ClrDialog.Color);
                panel1.Refresh();
            }
        }
    }
}