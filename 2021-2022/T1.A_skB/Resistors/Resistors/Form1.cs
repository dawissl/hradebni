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
                    throw new Exception("Neplatné hodnty!");
                }

                if (RadioSerial.Checked)
                {
                    R = R1 + R2;
                }

                if (RadioParalel.Checked)
                {
                    R = (R1 * R2) / (R1 + R2);
                }
                // | = alt + 124

                if (!(RadioParalel.Checked || RadioSerial.Checked))
                {
                    throw new Exception("Není vybraná žádná možnost");
                }
                              
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                LblResult.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LblResult.Text = "";
            }

        }
    }
}