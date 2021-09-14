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

        // deklarace hodnot pro vstup do kalkulačky
        int cisloA, cisloB;

        private void BtnMul_Click(object sender, EventArgs e)
        {
            cisloA = Convert.ToInt32(NumA.Value);
            cisloB = Convert.ToInt32(NumB.Value);
            LblResult.Text = (cisloA * cisloB).ToString();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            cisloA = Convert.ToInt32(NumA.Value);
            cisloB = Convert.ToInt32(NumB.Value);

            LblResult.Text = (cisloA + cisloB).ToString();
        }
    }
}
