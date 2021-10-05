using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalyzaCisla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            string result = "Pro číslo platí: ";
            int number = int.Parse(TxtNumber.Text);
            result += CheckEvenOdd(number);
            result += CheckPrime(number);
            result += CheckPositiveNegative(number);
            result += CheckDivider(number);
            result += CheckPerfect(number);
            LblAnalyze.Text = result;
        }

        private string CheckPerfect(int number)
        {
            
            int suma = 1;
            for (int i = 2; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    suma += i;
                }
            }
            if (suma == number)
            {
                return "dokonalé číslo";
            }
            else
            {
                return "";
            }
        }

        private string CheckDivider(int number)
        {
            string result = "Dělitelé: ";
            if (number == 0) return result;
            for (int divider = 2; divider <= 9; divider++)
            {
                if ((number % divider) == 0)
                {
                    // result = result + xxx <=> result += xxx
                    result += divider + ", ";
                }
            }
            return result;
        }

        private string CheckPositiveNegative(int number)
        {
            if (number > 0)
            {
                return "kladné, ";
            }
            else
            {
                return "záporné, ";
            }
        }

        private string CheckPrime(int number)
        {
            if(number <= 1) { return ""; }
            for (int i = 2; i <= number / 2; i++)
            {
                if ((number % i) == 0)
                {
                    return "";
                }
            }
            return "prvočíslo, ";
        }

        private string CheckEvenOdd(int number)
        {
            if ((number % 2) == 0)
            {
                return "sudé, ";
            }
            else
            {
                return "liché, ";
            }
        }
    }
}
