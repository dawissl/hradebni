namespace JednoduchaGrafika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            




            Random r = new Random();


            Point p = new Point(r.Next(0, 300), r.Next(0, 300));
            Point[] triangle = {
                p,
                new Point(r.Next(0,300),r.Next(0,300)),
                new Point(r.Next(0,300),r.Next(0,300)),
                p
            };

            if(CheckTriangle.Checked)
                g.DrawLines(Pens.Lime, triangle);

            int size = r.Next(0, 300);
            if(CheckCircle.Checked)
                g.FillEllipse(Brushes.Magenta,r.Next(0, 300), r.Next(0, 300), size, size);

            size = r.Next(0, 300);
            if(CheckSquare.Checked)
                g.FillRectangle(Brushes.Cyan, r.Next(0, 300), r.Next(0, 300), size, size);
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            Panel.Refresh();
        }
    }
}