using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalyzeNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            string res = "Analýza čísla: ";
            int number = int.Parse(TxtNumber.Text);
            res += AnalyzePositiveNegative(number);
            res += AnalyzeEvenOdd(number);
            res += Prime(number);
            res += Perfect(number);
            res += Dividers(number);

            LblResult.Text = res;

        }

        private string Dividers(int number)
        {
            string ret = "Dělitelé: ";
            for (int i = 2; i <= 9; i++)
            {
                if (number % i == 0)
                {
                    ret += i + ", ";
                }
            }
            

            return ret;
        }

        private string Perfect(int number)
        {
            int a = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i==0)
                {
                    a = a + i;
                }
            }
            if(a==number)
            {
                return "Dokonalé číslo, ";
            }
            else
            {
                return " ";
            }
        }
        private string Prime(int number)
        {
            if(number < 2)
            {
                return "";
            }

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0) { return ""; }
            }
            return "prvočíslo, ";
        }

        private string AnalyzeEvenOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "sudé, ";
            }
            else
            {
                return "liché, ";
            }
        }

        private string AnalyzePositiveNegative(int number)
        {
            if (number < 0)
            {
                return "zaporné, ";
            }
            else
            {
                return "kladné, ";
            }
        }
    }
}
