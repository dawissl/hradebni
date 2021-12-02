using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DummyCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        private void BtnSoucet_Click(object sender, EventArgs e)
        {
        
            LblVysledek.Text = $"{Convert.ToInt32(NumericA.Value) + Convert.ToInt32(NumericB.Value)}";

        }

        private void BtnRozdíl_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(NumericA.Value);
            b = Convert.ToInt32(NumericB.Value);
            LblVysledek.Text = $"{a - b}";

        }

        private void BtnSoucin_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(NumericA.Value);
            b = Convert.ToInt32(NumericB.Value);
            LblVysledek.Text = $"{a * b}";

        }
        /// <summary>
        /// funkce vrací kolik prvků v poli
        /// je větších než průměr hodnot pole
        /// </summary>
        /// <param name="array">vstupní pole hodnot</param>
        /// <returns>počet nadprůměrných hodnot</returns>
        private int Nadprumer(int[] array)
        {
            double threshold = array.Average();
            int counter = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > threshold) counter++;
            }

            return counter;
        }
    }
}
