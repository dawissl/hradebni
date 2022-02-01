using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateMatrice_Click(object sender, EventArgs e)
        {
            // deklarace dvourozměrného pole reprezentující matici
            int[,] matice = new int[8, 8];

            // TODO - naplnění matice
            if (radioBtnDefault.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        matice[i, j] = 1;
                    }
                }
            }
            int[] tmp = { 1, 2, 3, 4, 5, 6, 7, 8 };
            if (radioBtnSameColumns.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        matice[i, j] = tmp[i];
                    }
                }
            }

            if (radioBtnSameRows.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        matice[i, j] = tmp[j];
                    }
                }
            }

            if (radioBtnRandom.Checked)

            {
                // | - alt + 124
                if(txtFrom.Text == "" || txtTo.Text== "")
                {
                    MessageBox.Show("chybějicí hodnoty");
                    return;
                }
                Random rnd = new Random();
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        matice[i, j] = rnd.Next(
                            int.Parse(txtFrom.Text),
                            int.Parse(txtTo.Text) + 1);
                    }
                }
            }

            txtBoxMatrix.Text = PrintMatrix(matice,checkBoxDiagonal.Checked);

        }
        /// <summary>
        /// Function for generating matrix as a string
        /// </summary>
        /// <param name="matice">matrix 8x8</param>
        /// <param name="diagonal">print only diagonal</param>
        /// <returns>string representing matrix</returns>
        private string PrintMatrix(int[,] matice,bool diagonal)
        {
            string ret = "";

            // TODO naplnění řetězce
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {                    
                    // & - alt + 38
                    if (i != j && diagonal)
                    {
                        ret += "0, ";
                    }
                    else
                    {
                        ret += matice[i, j] + ", ";
                    }                    
                }
                // konstanta pro nový řádek na základě systému
                ret += Environment.NewLine;
            }

            return ret;
        }
    }
}
