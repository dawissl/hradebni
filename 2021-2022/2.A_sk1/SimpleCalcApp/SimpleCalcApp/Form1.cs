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

        private double numA, numB;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LoadNumbers();

            Lblresult.Text = (numB + numA).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Calc App","Info");
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            LoadNumbers();
            Lblresult.Text = (numA / numB).ToString();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            LoadNumbers();
            Lblresult.Text = (numA - numB).ToString();
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            LoadNumbers();

            Lblresult.Text = (numB * numA).ToString();
        }

        private void LoadNumbers()
        {
            numA = Convert.ToDouble(NumA.Value);
            numB = Convert.ToDouble(NumB.Value);
        }


    }
}
