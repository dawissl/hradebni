using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vyska = double.Parse(TxtHeight.Text);
            double vaha = double.Parse(TxtWeight.Text);
            double bmi = vaha / (vyska * vyska);

            if (checkBox1.Checked)
                MessageBox.Show(Info());

            if (radioMan.Checked)
                LblResult.Text = GetStatus(bmi).ToString();
            if (radioWoman.Checked)
                LblResult.Text = GetStatus(bmi + 1).ToString();
           /* switch (GetStatus(bmi))
            {
                case Status.PODVAHA:
                    LblResult.BackColor = Color.Orange;
                    break;
                case Status.NORMALNI:
                    LblResult.BackColor = Color.Green;
                    break;
                case Status.LEHKA_OBEZITA:
                    LblResult.BackColor = Color.Yellow;
                    break;
                case Status.STREDNI_OBEZITA:
                    LblResult.BackColor = Color.Orange;
                    break;
                case Status.VYSOKA_OBEZITA:
                    LblResult.BackColor = Color.Red;
                    break;
            }*/

        }

        private Status GetStatus(double bmi)
        {
            if (bmi < 20) return Status.PODVAHA;
            if (bmi >= 20 && bmi <= 24.9) return Status.NORMALNI;
            if (bmi > 25 && bmi <= 29.9) return Status.LEHKA_OBEZITA;
            if (bmi > 30 && bmi <= 39.9) return Status.STREDNI_OBEZITA;
            if (bmi > 40) return Status.VYSOKA_OBEZITA;
            return Status.NEZNAMY;
        }

        private string Info()
        {
            return "Tradá";
        }

        public enum Status { PODVAHA, NORMALNI, LEHKA_OBEZITA, STREDNI_OBEZITA, VYSOKA_OBEZITA, NEZNAMY }
    }
}
