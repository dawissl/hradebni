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

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            LblResult.ForeColor = Color.Black;
            try
            {
                double vstupA = double.Parse(TxtVstupA.Text);
                double vstupB = double.Parse(TxtVstupB.Text);


                double result = 0;

                if (RbtnAdd.Checked)
                {
                    result = vstupA + vstupB;
                }

                if (RbtnSub.Checked)
                {
                    result = vstupA - vstupB;
                }

                if (RbtnDiv.Checked)
                {
                    if (vstupB == 0)
                    {
                        MessageBox.Show("Nelze dělit nulou");
                    }
                    else
                    {
                        result = vstupA / vstupB;
                    }
                }

                if (RbtnMul.Checked)
                {
                    result = vstupA * vstupB;
                }

                if (RbtnPow.Checked)
                {
                    result = Math.Pow(vstupA, vstupB);
                }

                if (ChBNegative.Checked)
                {
                    if(result < 0)
                    {
                        LblResult.ForeColor = Color.Red;
                    }
                    else
                    {
                        LblResult.ForeColor = Color.Blue;
                    }               
                }

                

                if (ChBRound.Checked)
                {
                    result = Math.Round(result);
                }

                LblResult.Text = result.ToString();
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
