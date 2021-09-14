using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalcApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int numA, numB, result;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            numA = Convert.ToInt32(NumA.Value);
            numB = Convert.ToInt32(NumB.Value)
            //result = numA + numB;
            //LblResult.Text = result.ToString();
            LblResult.Text = (numA + numB).ToString();
        }
    }
}
