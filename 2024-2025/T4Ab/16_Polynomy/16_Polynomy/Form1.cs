namespace _16_Polynomy
{
    public partial class Form1 : Form
    {
        private bool draw = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            draw = true;
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (!draw) return;
            Graphics g = e.Graphics;
            // TODO draw axes
            foreach (Polynom p in ListPolynoms.CheckedItems)
            {
                g.DrawLines(p.Line, p.GetFunction());
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Polynom p = new Polynom(double.Parse(txtA.Text),
                double.Parse(TxtB.Text),
                double.Parse(TxtC.Text),
                double.Parse(TxtD.Text));
            ListPolynoms.Items.Add(p);
        }
    }
}
