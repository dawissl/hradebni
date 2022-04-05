namespace Polynom
{
    public partial class Form1 : Form
    {
        private Point[] points;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            // 1,23,5,6,8,78,...
            if (TxtInput.Text == "")
            {
                MessageBox.Show("Zadejte vstupní pole");
                return;
            }
            string[] hodnotaY = TxtInput.Text.Split(",");
            points = new Point[hodnotaY.Length];

            for (int x = 0; x < points.Length; x++)
            {
                points[x] = new Point(x*10,
                    int.Parse(hodnotaY[x].Trim())
                    );
            }

            Panel.Refresh();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
           
            if(points != null)
            {
                Graphics g = e.Graphics;
                g.DrawLines(Pens.Red, points);
            }
        }
    }
}