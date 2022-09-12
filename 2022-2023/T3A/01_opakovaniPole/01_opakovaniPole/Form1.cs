using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_opakovaniPole
{
    public partial class Form1 : Form
    {
        private double[] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerateArray_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int size = (int)NumericArraySize.Value;
            // deklarace nového pole o zvolené velikosti
            array = new double[size];
            //prázdný řetězec pro výpis
            string stringArr = "";
            for (int i = 0; i < size; i++)
            {
                // vygenerování náhodné hodnoty <0,50>
                array[i] = rnd.Next(0,51);
                // přidání vygenerované hodnoty na konec řetězce
                stringArr += $"{array[i]}, ";
            }
            // výpis pole do připraveného labelu
            LblArray.Text = stringArr;
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            if (LblArray.Text == "")
            {
                MessageBox.Show("Chybí vygenerované pole!");
                return;
            }
            double sum = 0;
            for(int i = 0; i<array.Length; i++)
            {
                sum += array[i];
            }
            LblOut.Text = $"Součet: {sum}";
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            if (LblArray.Text == "")
            {
                MessageBox.Show("Chybí vygenerované pole!");
                return;
            }
            double result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result *= array[i];
            }
            LblOut.Text = $"Součin: {result}";
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            if (LblArray.Text == "")
            {
                MessageBox.Show("Chybí vygenerované pole!");
                return;
            }

            LblOut.Text = $"Maximum: {array.Max()}";
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            if (LblArray.Text == "")
            {
                MessageBox.Show("Chybí vygenerované pole!");
                return;
            }

            LblOut.Text = $"Minumum: {array.Min()}";
        }
    }
}
