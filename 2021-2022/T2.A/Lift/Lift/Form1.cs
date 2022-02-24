using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift
{
    public partial class Form1 : Form
    {
        private int vaha = 0;
        private int pocet = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtLift.Text = "";
            TxtWeight.Text = "";
            vaha = 0;
            pocet = 0;
            LblWeight.BackColor = Color.Lime;
            LblCount.BackColor = Color.Lime;

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            int weight = int.Parse(TxtWeight.Text);

            if (vaha + weight > 600)
            {
                LblWeight.BackColor = Color.Red;
            }
            vaha += weight;

            if (pocet + 1 > 8)
            {
                LblCount.BackColor = Color.Red;
            }
            pocet++;

            TxtLift.Text += $"{weight}{Environment.NewLine}";
        }
    }
}
