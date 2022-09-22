using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_GenerovanePole
{
    public partial class Form1 : Form
    {
        private int[] pole;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerateArray_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            pole = new int[(int)NumericArraySize.Value];
            LblArray.Text = "";
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = rng.Next(1, 51);
                // $ = alt + 36
                LblArray.Text += $"{pole[i]}, ";
            }
             
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < pole.Length; i++)
                sum += pole[i];
            LblOut.Text = $"{sum}";
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            long mul = 1;
            for (int i = 0; i < pole.Length; i++)
                mul *= pole[i];
            LblOut.Text = $"{mul}";
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            LblOut.Text = $"{pole.Max()}";
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            LblOut.Text = $"{pole.Min()}";

        }
    }
}
