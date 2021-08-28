using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColouredForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            // měníme atribut BackColor této třídy, tedy formuláře
            BackColor = Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            // nově vytvořená barva bude reprezentována kanály RGB
            BackColor = Color.FromArgb(Convert.ToInt32(numRed.Value),
                                       Convert.ToInt32(numGreen.Value),
                                       Convert.ToInt32(numBlue.Value));
        }
    }
}
