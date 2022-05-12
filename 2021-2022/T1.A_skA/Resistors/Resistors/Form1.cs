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
                    throw new Exception("Hodnoty mus� b�t kladn� a v�t�� ne� 0");
                }

                if (RadioParalel.Checked)
                {
                    // paraleln� zapojen�
                    R = R1 * R2 / (R1 + R2);
                }

                if (RadioSerial.Checked)
                {
                    // seriov� zapojen�
                    R = R1 + R2;
                }

                // | = alt + 124
                if (!(RadioParalel.Checked || RadioSerial.Checked))
                {
                    throw new Exception("Nen� vybran� mo�nost zapojen�");
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