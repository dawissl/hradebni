using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(NumericA.Value);
            int b = Convert.ToInt32(NumericB.Value);
            int c = Convert.ToInt32(NumericC.Value);

            if (TriangleCheck(a, b, c))
            {
                LblResult.BackColor = Color.Green;
                double tmp = (a + b + c) / 2.0;
                double s = Math.Sqrt(tmp * (tmp - a) * (tmp - b) * (tmp - c));
                LblResult.Text = s.ToString();
            }
            else
            {
                LblResult.BackColor = Color.Red;
            }
        }

        private bool TriangleCheck(int a, int b, int c)
        {
           /* if (a + b <= c) return false;
            if (c + b <= a) return false;
            if (a + c <= b) return false;
            return true;
            */

            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}
