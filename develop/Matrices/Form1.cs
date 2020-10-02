using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices
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
            txtBoxMatrix.Text = "";

            if (radioBtnDefault.Checked)
            {
                matrix = fillMatrix(Option.VYCHOZI);
            }

            if (radioBtnSameColumns.Checked)
            {
                matrix = fillMatrix(Option.STEJNE_SLOUPCE);
            }

            if (radioBtnSameRows.Checked)
            {
                matrix = fillMatrix(Option.STEJNE_RADKY);
            }

            if (radioBtnRandom.Checked)
            {
                if (txtFrom.Text.Equals("") || txtTo.Text.Equals(""))
                {
                    MessageBox.Show("Zadejte prosím rozsah hodnot");
                }
                else
                {
                    matrix = fillMatrix(Option.NAHODNE, int.Parse(txtFrom.Text), int.Parse(txtTo.Text));
                }

            }

            txtBoxMatrix.Text = printMatrix(matrix);
        }

        private int[,] fillMatrix(Option option)
        {
            int[,] m = new int[8, 8];
            int[] tmp = { 1, 2, 3, 4, 5, 6, 7, 8 };
            if (option.Equals(Option.VYCHOZI))
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        m[i, j] = tmp[0];
                    }
                }
            }

            if (option.Equals(Option.STEJNE_RADKY))
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        m[i, j] = tmp[i];
                    }
                }
            }

            if (option.Equals(Option.STEJNE_SLOUPCE))
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        m[i, j] = tmp[j];
                    }
                }
            }

            return m;
        }

        private int[,] fillMatrix(Option option, int from, int to)
        {
            int[,] m = new int[8, 8];
            Random rnd = new Random();
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    m[i, j] = rnd.Next(from, to);
                }
            }

            return m;
        }

        private string printMatrix(int[,] matrix)
        {
            string m = "";
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (checkBoxDiagonal.Checked)
                    {
                        if (i == j)
                        {
                            m += matrix[i, j] + ", ";
                        }
                        else
                        {
                            m += "0, ";
                        }
                    }
                    else
                    {
                        m += matrix[i, j] + ", ";
                    }

                }
                m += Environment.NewLine;
            }
            return m;
        }


    }
    public enum Option
    {
        VYCHOZI, STEJNE_RADKY, STEJNE_SLOUPCE, NAHODNE
    }


}
