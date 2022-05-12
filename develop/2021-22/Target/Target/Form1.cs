namespace Target
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (NumLayers.Value > 40)
            {
                timer1.Enabled = false;
                return;
            }
            Graphics g = e.Graphics;
            int size = 400;
            int step = 10;
            int halfStep = step / 2;

            SolidBrush major = new SolidBrush(LblMajor.BackColor);
            SolidBrush minor = new SolidBrush(LblMinor.BackColor);

            for (int i = 0; i < (int)NumLayers.Value; i++)
            {
                if (i % 2 == 0)
                {
                    g.FillEllipse(major, i * halfStep, i * halfStep, size - i * step, size - i * step);
                }
                else
                {
                    g.FillEllipse(minor, i * halfStep, i * halfStep, size - i * step, size - i * step);
                }
            }
        }

        private void BtnTarget_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void LblMajor_Click(object sender, EventArgs e)
        {
            if (ColorMajor.ShowDialog() == DialogResult.OK)
            {
                LblMajor.BackColor = ColorMajor.Color;
            }
        }

        private void LblMinor_Click(object sender, EventArgs e)
        {
            if (ColorMinor.ShowDialog() == DialogResult.OK)
            {
                LblMinor.BackColor = ColorMinor.Color;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (NumLayers.Value > 40)
            {
                MessageBox.Show("Dosažen maximální poèet vrstev");
                timer1.Enabled = false;
     
            }
            else
            {
                NumLayers.Value++;
                panel1.Refresh();
            }
            
        }
    }
}