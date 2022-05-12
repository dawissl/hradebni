namespace Resistors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                double R1, R2, R = -1;
                R1 = double.Parse(TxtR1.Text);
                R2 = double.Parse(TxtR2.Text);

                if (R1 <= 0 || R2 <= 0)
                {
                    throw new Exception("Hodnoty musí být kladné a vìtší než 0");
                }

                if (RadioParalel.Checked)
                {
                    // paralelní zapojení
                    R = R1 * R2 / (R1 + R2);
                }

                if (RadioSerial.Checked)
                {
                    // seriové zapojení
                    R = R1 + R2;
                }

                // | = alt + 124
                if (!(RadioParalel.Checked || RadioSerial.Checked))
                {
                    throw new Exception("Není vybraná možnost zapojení");
                }
                // $ = alt + 36
                LblResult.Text = $"{R} Ohm";
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}