using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoolAlgebra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            bool a1 = true;
            bool a2 = false;
            bool a3 = true;
            bool a4 = false;

            bool b1 = true;
            bool b2 = true;
            bool b3 = false;
            bool b4 = false;

            if (CheckBoxNegA.Checked)
            {
                a1 = !a1;
                a2 = !a2;
                a3 = !a3;
                a4 = !a4;
            }

            if (CheckBoxNegB.Checked)
            {
                b1 = !b1;
                b2 = !b2;
                b3 = !b3;
                b4 = !b4;
            }
            // and && alt + 38
            if (RadioAnd.Checked)
            {
                Txt1.Text = (a1 && b1).ToString();
                Txt2.Text = (a2 && b2).ToString();
                Txt3.Text = (a3 && b3).ToString();
                Txt4.Text = (a4 && b4).ToString();
            }
            else
            {
             
            }

            // or || alt+124
            if (RadioOR.Checked )
            {
                Txt1.Text = (a1 || b1).ToString();
                Txt2.Text = (a2 || b2).ToString();
                Txt3.Text = (a3 || b3).ToString();
                Txt4.Text = (a4 || b4).ToString();
            }
        

            //xor ^ alt + 94
            if (RadioXOR.Checked)
            {
                Txt1.Text = (a1 ^ b1).ToString();
                Txt2.Text = (a2 ^ b2).ToString();
                Txt3.Text = (a3 ^ b3).ToString();
                Txt4.Text = (a4 ^ b4).ToString();
            }

        }
    }
}
