namespace _03_DlouheCislo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            string vystup = $"Analıza vstupního èísla{Environment.NewLine}============================{Environment.NewLine}";
            string vstup = TxtNumber.Text;
            int liche = 0;
            int sude = 0;
            // pomocné pole do kterého pøevedeme vstupní èíslo po cifrách
            int[] number = new int[vstup.Length];
            // pomocné pole zjišující poèet vıskytù cifer
            int[] countDigit = new int[10];
            for (int i = 0; i < number.Length; i++)
            {
                // ziskani èíslené hodnoty z char
                number[i] = (int)Char.GetNumericValue(vstup[i]);
                // poèítání sudıch a lichıch cifer
                if (number[i] % 2 == 0)
                    sude++;
                else
                    liche++;
                // poèítání vıskytù danıch cifer
                countDigit[number[i]]++;
            }
            // $ = alt + 36
            vystup += $"Sudá èísla: {sude} - ";
            for (int i = 0; i < countDigit.Length; i += 2)
            {
                if (countDigit[i] > 0)
                    vystup += $"{i}, ";
            }
            vystup += $"{Environment.NewLine}Lichá èísla: {liche} - ";
            for (int i = 1; i < countDigit.Length; i += 2)
            {
                if (countDigit[i] > 0)
                    vystup += $"{i}, ";
            }
            vystup += $"{Environment.NewLine}Chybìjící cifry: ";
            for (int i = 0; i < countDigit.Length; i++)
            {
                if (countDigit[i] == 0) vystup += $"{i}, ";
            }

            vystup += $"{Environment.NewLine}Nejèastìjší hodnota: ";
            int index = 0;
            int max = countDigit[index];
            for (int i = 1; i < countDigit.Length; i++)
            {
                if (countDigit[i] > max)
                {
                    index = i;
                    max = countDigit[index];
                }
            }
            vystup += $"{index}{Environment.NewLine}";

            // TODO
            // countDigit = {0,2,3,1,0,1,0,1,1,0}
            vystup += $"Nejvyšší moné èíslo:";
            for (int i = countDigit.Length - 1; i >= 0; i--)
            {
                while (countDigit[i] > 0)
                {
                    vystup += $"{i}";
                    countDigit[i] -- ;
                }
            }
            

            TxtOut.Text = vystup;
        }
    }
}