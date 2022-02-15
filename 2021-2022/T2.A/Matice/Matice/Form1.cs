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
            int[,] matrix = new int[8, 8];

            if(radioBtnDefault.Checked) {
                // TODO plnit pole jedničkami
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = 1;
                    }
                    
                }
            }
            int[] tmp = { 1, 2, 3, 4, 5, 6, 7, 8 };
            if (radioBtnSameColumns.Checked)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = tmp[i];
                    }

                }
            }

            if (radioBtnSameRows.Checked)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = tmp[j] ;
                    }

                }
            }

            txtBoxMatrix.Text = printMatrix(matrix);
        }

        private string printMatrix(int[,] matrix)
        {
            string ret = "";
           
            // TODO vypsat matici
            for (int i=0;i<matrix.GetLength(0);i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    ret += $"{matrix[i, j]}, "; 
                }
                ret += Environment.NewLine;

            }
            return ret;
        }
    }
}
