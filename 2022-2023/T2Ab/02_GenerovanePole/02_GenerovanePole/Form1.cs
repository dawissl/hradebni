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
            BtnSum.Enabled = false;
        }

        private void BtnGenerateArray_Click(object sender, EventArgs e)
        {
            pole = new int[(int)NumericArraySize.Value];
            Random rnd = new Random();
            LblArray.Text = "";
            for (int i = (int)NumericArraySize.Value - 1; i >= 0; i--)
            {
                pole[i] = rnd.Next(1, 51);
                // $ = alt + 36
                LblArray.Text += $"{pole[i]}, ";
            }

            BtnSum.Enabled = true;

        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            int suma = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                suma += pole[i];
            }
            LblOut.Text = $"{suma}";
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            if(LblArray.Text == "")
            {
                MessageBox.Show("chybi vygenerované pole");
                return;
            }
            int result = 1;
            for (int i = 0; i < pole.Length; i++)
            {
                result *= pole[i];
            }
            LblOut.Text = $"{result}";
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
