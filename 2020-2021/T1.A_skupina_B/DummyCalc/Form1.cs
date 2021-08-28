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
                double vysledek = 0;

                if (RbtnAdd.Checked)
                {
                    vysledek = vstupA + vstupB;
                }

                if (RbtnSub.Checked)
                {
                    vysledek = vstupA - vstupB;
                }

                if (RbtnMul.Checked)
                {
                    vysledek = vstupA * vstupB;
                }

                if (RbtnDiv.Checked)
                {
                    if (vstupB == 0)
                    {
                        MessageBox.Show("Nelze dělit nulou!");
                    }
                    else
                    {
                        vysledek = vstupA / vstupB;
                    }
                }

                if (RbtnPow.Checked)
                {
                    vysledek = Math.Pow(vstupA,vstupB);
                }

                if (ChBColor.Checked)
                {
                    if(vysledek < 0)
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
                    vysledek = Math.Round(vysledek);
                }

                LblResult.Text = vysledek.ToString();
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
