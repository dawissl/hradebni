namespace _04_DlouheCislo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            string vystup = $"Analýza vstupního èísla{Environment.NewLine}============================{Environment.NewLine}";
            int[] cislo = new int[TxtNumber.Text.Length];
            int[] cifry = new int[10];
            int sude = 0;
            int liche = 0;
            for (int i = 0; i < cislo.Length; i++)
            {
                cislo[i] = (int)Char.GetNumericValue(TxtNumber.Text[i]);

                if ((cislo[i] % 2) == 0)
                {
                    sude++;
                }
                else
                {
                    liche++;
                }

                cifry[cislo[i]]++;
            }

            vystup += $"Sudá èísla: poèet {sude} {{";

            for (int i = 0; i < cifry.Length; i++)
            {
                if (i % 2 == 0 && cifry[i] > 0)
                {
                    vystup += $"{i}, ";
                }
            }


            vystup += $"}}{Environment.NewLine}Licha èísla: poèet {liche} {{";

            for (int i = 0; i < cifry.Length; i++)
            {
                if (i % 2 == 1 && cifry[i] > 0)
                {
                    vystup += $"{i}, ";
                }
            }
            vystup += $" }}{Environment.NewLine}Chybìjící cifry: ";
            for (int i = 0; i < cifry.Length; i++)
            {
                if (cifry[i] == 0)
                {
                    vystup += $"{i}, ";
                }
            }

            int index = 0;
            int max = cifry[index];
            for(int i = 1; i < cifry.Length; i++)
            {
                if (cifry[i] > max)
                {
                    index = i;
                    max = cifry[i];
                }
            }
            vystup += $"{Environment.NewLine}Nejèastìjší cifra: {index} ";
            /// TODO  - analyza cisla

            TxtOut.Text = vystup;
        }
    }
}