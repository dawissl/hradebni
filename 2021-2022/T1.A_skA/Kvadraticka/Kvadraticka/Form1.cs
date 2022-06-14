namespace Kvadraticka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(TxtA.Text);
            double b = double.Parse(TxtB.Text);
            double c = double.Parse(TxtC.Text);

            double d = b * b - 4 * a * c;
            TxtD.Text = $"{d}";
            
            TxtX1.Text = "";
            TxtX2.Text = "";
            if (d < 0)
            {
                MessageBox.Show("Nemá øešení v R");
                return;
            }
            if (d == 0)
            {
                double x = (-1) * b / (2 * a);
                TxtX1.Text = x.ToString();
                TxtX2.Text = x.ToString();
            }
            if (d > 0)
            {
                double x1 = ((-1) * b + Math.Sqrt(d)) / (2 * a);
                double x2 = ((-1) * b - Math.Sqrt(d)) / (2 * a);
                
                TxtX1.Text = $"{Math.Round(x1,3)}";
                TxtX2.Text = $"{Math.Round(x2,3)}";
            }
        }
    }
}