namespace _09_Matice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPrin_Click(object sender, EventArgs e)
        {
            int[,] matice = new int[5, 5];

            // jednotkova matice
            if (RadioSimple.Checked)
            {
                matice = FillSameMatrix(matice, 1);
            }

            if (RadioRows.Checked)
            {
                for (int i = 0; i < matice.GetLength(0); i++)
                {
                    for (int j = 0; j < matice.GetLength(1); j++)
                    {
                        matice[i, j] = i+1;
                    }
                }
            }

            if (RadioColumns.Checked)
            {
                for (int i = 0; i < matice.GetLength(0); i++)
                {
                    for (int j = 0; j < matice.GetLength(1); j++)
                    {
                        matice[i, j] = j+1;
                    }
                }
            }


            LblMatrix.Text = VypisMatici(matice,CheckDiagonal.Checked);
        }

        private int[,] FillSameMatrix(int[,] matice, int value)
        {

            for (int i = 0; i < matice.GetLength(0); i++)
            {
                for (int j = 0; j < matice.GetLength(1); j++)
                {
                    matice[i, j] = value;
                }
            }
            return matice;
        }

        private string VypisMatici(int[,] matice)
        {
            string tmp = "";

            for(int i = 0; i < matice.GetLength(0); i++)
            {
                for(int j = 0; j < matice.GetLength(1); j++)
                {
                    tmp += $"{matice[i,j]}, ";
                }
                tmp += Environment.NewLine;
            }

            return tmp;
        }

        private string VypisMatici(int[,] matice, bool diagonal)
        {
            string tmp = "";

            // TODO naplnìní øetìzce tmp hodnotami z matice
            for (int i = 0; i < matice.GetLength(0); i++)
            {
                for (int j = 0; j < matice.GetLength(1); j++)
                {
                    if (diagonal)
                    {
                        tmp += (i == j) ? $"{matice[i, j]}, " : "0, ";
                    }
                    else
                    {
                        tmp += $"{matice[i, j]}, ";
                    }

                }
                tmp += Environment.NewLine;
            }

            return tmp;
        }
    }
}