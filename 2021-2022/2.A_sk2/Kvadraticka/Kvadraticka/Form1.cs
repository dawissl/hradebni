using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kvadraticka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            //vyčištění labelů pro zápis výsledků
            LblX1.Text = "";
            LblX2.Text = "";
            LblD.Text = "";
            //ziskání hodnot z rovnice
            double numA = double.Parse(TxtA.Text);
            double numB = double.Parse(TxtB.Text);
            double numC = double.Parse(TxtC.Text);
            // kontrola zda se jedná o polynom druhého stupně
            if(numA == 0)
            {
                MessageBox.Show("Zadané hodnoty neodpovídají kvadratické rovnici");
                return;
            }
            //výpočet diskriminantnu
            double D = numB * numB - 4 * numA * numC;

            if (D < 0)
            {
                MessageBox.Show("Rovnice nemá řešení v oboru R");
            }
            else
            {

                double x1, x2;
                if (D == 0) // kořeny mají stejnou hodnotu
                {
                    x1 = (-numB) / (2 * numA);
                    x2 = x1;

                }
                else
                { // kořeny mají různou hodnotu
                    double tmp = Math.Sqrt(D);
                    x1 = (-numB + tmp) / (2 * numA);
                    x2 = (-numB - tmp) / (2 * numA);
                }
                LblX1.Text = x1.ToString();
                LblX2.Text = x2.ToString();

            }
            // diskriminant vypíšeme bez ohledu na možnost řešení
            LblD.Text = D.ToString();
        }
    }
}
