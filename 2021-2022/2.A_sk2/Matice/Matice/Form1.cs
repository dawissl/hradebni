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

            // naplnění matice podle volby uživatele
            if (radioBtnDefault.Checked)
            {               
                for (int i = 0; i < matice.GetLength(0); i++)
                {
                    for (int j = 0; j < matice.GetLength(1); j++)
                    {
                        matice[i, j] = 1 ;
                    }                   
                }
            }
            // pomocné pole pro hodnoty v matici
            int[] tmp = { 1, 2, 3, 4, 5, 6, 7, 8 };
            if (radioBtnSameColumns.Checked)
            {
                // projití pole v souřadnicich x,y a naplnění
                for (int i = 0; i < matice.GetLength(0); i++)
                {
                    for (int j = 0; j < matice.GetLength(1); j++)
                    {
                        matice[i, j] = tmp[i];
                    }
                }
            }
            if (radioBtnSameRows.Checked)
            {
                for (int i = 0; i < matice.GetLength(0); i++)
                {
                    for (int j = 0; j < matice.GetLength(1); j++)
                    {
                        matice[i, j] = tmp[j];
                    }
                }
            }

            txtBoxMatrix.Text = vypisMatice(matice);
        }
        /// <summary>
        /// Příprava matice pro výpis
        /// </summary>
        /// <param name="matice">vstupní matice</param>
        /// <returns>řetezec reprezentující matici</returns>
        private string vypisMatice(int[,] matice)
        {
            string ret = "";

            for (int i = 0; i <matice.GetLength(0); i++)
            {
                for (int j = 0; j < matice.GetLength(1); j++)
                {
                    ret += $"{ matice[i, j]}, "; 
                }
                ret += Environment.NewLine;
            }

            return ret;
        }
    }
}
