using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarvyFormulare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void BtnGreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void BtnBlue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void BtnOwn_Click(object sender, EventArgs e)
        {
            int red = Convert.ToInt32(NumericRed.Value);
            int green = Convert.ToInt32(NumericGreen.Value);
            int blue = Convert.ToInt32(NumericBlue.Value);

            BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
