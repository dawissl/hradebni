namespace MenuLines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripComboBox1.Text = "---";
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informace o programu");
        }

        private void zavøítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (toolStripComboBox1.Text == "---")
            {
                g.FillRectangle(Brushes.Red,

                    ToCartez(panel1.Width / 2,
                    panel1.Height / 2).X,

                    ToCartez(panel1.Width / 2,
                    panel1.Height / 2).Y,
                    20, 20);
            }

            if (toolStripComboBox1.Text == "Zobrazit pøímku")
            {
                Point p1 = ToCartez(new Point(0, 0));
                Point p2 = ToCartez(new Point(100, 100));
                g.DrawLine(Pens.Blue, p1, p2);
            }

            if (toolStripComboBox1.Text == "Zobrazit 2 pøímky")
            {
                Point[] line1 = { new Point(0, 0), new Point(100, 100) };
                Point[] line2 = { new Point(50, 0), new Point(30, 100) };
                Point vektorl1n = new Point(-1 * (line1[1].Y - line1[0].Y),
                                            line1[1].X - line1[0].X);

                Point vektorl2n = new Point(-1 * (line2[1].Y - line2[0].Y),
                                            line2[1].X - line2[0].X);
                Line1.Text = $"y = {vektorl1n.X}x +{vektorl1n.Y}";

                g.DrawLines(Pens.Blue, line1);
                g.DrawLines(Pens.Magenta, line2);

            }

            if (toolStripComboBox1.Text == "Zobrazit pøímku a bod")
            {

                g.DrawLine(Pens.Magenta, new Point(50, 0),
                    new Point(30, 100));
                g.FillEllipse(Brushes.Green, 50, 50, 5, 5);
            }
        }

        private Point ToCartez(int x, int y)
        {
            return new Point(x, panel1.Width - y);
        }

        private Point ToCartez(Point p)
        {
            return new Point(p.X, panel1.Width - p.Y);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }


    }
}