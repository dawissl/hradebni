using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarvyFormuláře
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void BtnCustom_Click(object sender, EventArgs e)
        {
            int red = Convert.ToInt32(NumRed.Value);
            int green = Convert.ToInt32(NumGreen.Value);
            int blue = Convert.ToInt32(NumBlue.Value);

            BackColor = Color.FromArgb(red,green,blue);
        }

        private void BtnGreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;

        }

        private void BtnBlue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;

        }
    }
}
