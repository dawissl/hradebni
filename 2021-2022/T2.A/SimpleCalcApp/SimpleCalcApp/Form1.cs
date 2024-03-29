﻿using System;
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

        private void BtnMul_Click(object sender, EventArgs e)
        {
            LoadNumbers();
            LblResult.Text = (numA * numB).ToString();

        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            LoadNumbers();
            LblResult.Text = (numA - numB).ToString();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            LoadNumbers();
            if (numB == 0)
            {
                MessageBox.Show("Nelze dělit nulou!");
            }
            LblResult.Text = (numA / numB).ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LoadNumbers();
            LblResult.Text = (numA + numB).ToString();
        }

        private void LoadNumbers()
        {
            numA = Convert.ToDouble(NumA.Value);
            numB = Convert.ToDouble(NumB.Value);

        }
    }
}
