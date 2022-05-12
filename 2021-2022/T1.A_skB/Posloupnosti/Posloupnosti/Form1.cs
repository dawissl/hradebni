using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
