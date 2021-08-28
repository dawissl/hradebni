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

        private void btnGreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int red = Convert.ToInt32(numericRed.Value);
            int green = Convert.ToInt32(numericGreen.Value);
            int blue = Convert.ToInt32(numericBlue.Value);

            BackColor = Color.FromArgb(red, green, blue);
            btnCreate.BackColor = Color.FromArgb(red, green, blue);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGreen.BackColor = Color.Green;
            btnRed.BackColor = Color.Red;
            btnBlue.BackColor = Color.Blue;
        }
    }
}
