namespace Posloupnosti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            double a1, qD, n;

            n = Convert.ToDouble(NumericN.Value);
            if (n <= 0)
            {
                MessageBox.Show("Neplatný vstup N");
                return;
            }
            a1 = double.Parse(TxtA1.Text);
            qD = double.Parse(TxtQD.Text);

            for (int i = 2; i <= n; i++)
            {
                if (Aritmetic.Checked)
                {
                    // aritmetická
                    a1 = a1 + qD;
                }

                if (Geometric.Checked)
                {
                    // geometrická
                    a1 = a1 * qD;
                }
            }

            LblResult.Text = a1.ToString();
            LblResult.Text = $"{a1}";
        }
    }
}