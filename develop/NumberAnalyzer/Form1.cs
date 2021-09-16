using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikace analyzátoru čísla umožňuje zjistit několik základních " +
                "charakteristik zadávaného čísla", "Analyzátor čísla");

        }

        private void Number_ValueChanged(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(Number.Value);
            EvenOddCheck(number);
            PositiveNegativeCheck(number);
            PrimeCheck(number);
            DividedByCheck(number);
            PerfectNumberCheck(number);
        }

        private void PerfectNumberCheck(int number)
        {
            if(number <= 0)
            {
                LblPerfect.ForeColor = Color.Red;
                return;
            }
            int sum = 0;
            for(int i = 1; i <= number/2; i++)
            {
                if(number % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == number)
            {
                LblPerfect.ForeColor = Color.Green;
            }
            else
            {
                LblPerfect.ForeColor = Color.Red;
            }
   
        }

        private void DividedByCheck(int number)
        {
            LblDividedBy2.ForeColor = Color.Red;
            LblDividedBy3.ForeColor = Color.Red;
            LblDividedBy4.ForeColor = Color.Red;
            LblDividedBy5.ForeColor = Color.Red;
            LblDividedBy6.ForeColor = Color.Red;
            LblDividedBy7.ForeColor = Color.Red;
            LblDividedBy8.ForeColor = Color.Red;
            LblDividedBy9.ForeColor = Color.Red;

            for (int i = 2; i <= 9; i++)
            {
                if(number % i == 0)
                {
                    switch (i)
                    {
                        case 2:
                            LblDividedBy2.ForeColor = Color.Green;
                            break;
                        case 3:
                            LblDividedBy3.ForeColor = Color.Green;
                            break;
                        case 4:
                            LblDividedBy4.ForeColor = Color.Green;
                            break;
                        case 5:
                            LblDividedBy5.ForeColor = Color.Green;
                            break;
                        case 6:
                            LblDividedBy6.ForeColor = Color.Green;
                            break;
                        case 7:
                            LblDividedBy7.ForeColor = Color.Green;
                            break;
                        case 8:
                            LblDividedBy8.ForeColor = Color.Green;
                            break;
                        case 9:
                            LblDividedBy9.ForeColor = Color.Green;
                            break;
                    }
                }
            }
        }

        private void PrimeCheck(int number)
        {
            if(number <= 1)
            {
                LblPrime.ForeColor = Color.Red;
                return;
            }
            for (int i=2; i < number / 2; i++)
            {
                if(number % i == 0)
                {
                    LblPrime.ForeColor = Color.Red;
                    return;
                }
            }
            LblPrime.ForeColor = Color.Green;

        }

        private void PositiveNegativeCheck(int number)
        {
            if(number == 0)
            {
                LblNegative.ForeColor = Color.Red;
                LblPositive.ForeColor = Color.Red;
            }
            else
            {
                if(number > 0)
                {
                    LblNegative.ForeColor = Color.Red;
                    LblPositive.ForeColor = Color.Green;
                }
                else
                {
                    LblNegative.ForeColor = Color.Green;
                    LblPositive.ForeColor = Color.Red;
                }
            }
        }

        private void EvenOddCheck(int number)
        {
            if (number < 0) number *= -1;
            if(number % 2 == 1)
            {
                LblOdd.ForeColor = Color.Green;
                LblEven.ForeColor = Color.Red;
            }
            else
            {
                LblOdd.ForeColor = Color.Red;
                LblEven.ForeColor = Color.Green;
            }
        }
    }
}
