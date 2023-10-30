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
            string vystup = $"Anal�za vstupn�ho ��sla{Environment.NewLine}============================{Environment.NewLine}";
            string vstup = TxtNumber.Text;
            int liche = 0;
            int sude = 0;
            // pomocn� pole do kter�ho p�evedeme vstupn� ��slo po cifr�ch
            int[] number = new int[vstup.Length];
            // pomocn� pole zji��uj�c� po�et v�skyt� cifer
            int[] countDigit = new int[10];
            for (int i = 0; i < number.Length; i++)
            {
                // ziskani ��slen� hodnoty z char
                number[i] = (int)Char.GetNumericValue(vstup[i]);
                // po��t�n� sud�ch a lich�ch cifer
                if (number[i] % 2 == 0)
                    sude++;
                else
                    liche++;
                // po��t�n� v�skyt� dan�ch cifer
                countDigit[number[i]]++;
            }
            // $ = alt + 36
            vystup += $"Sud� ��sla: {sude} - ";
            for (int i = 0; i < countDigit.Length; i += 2)
            {
                if (countDigit[i] > 0)
                    vystup += $"{i}, ";
            }
            vystup += $"{Environment.NewLine}Lich� ��sla: {liche} - ";
            for (int i = 1; i < countDigit.Length; i += 2)
            {
                if (countDigit[i] > 0)
                    vystup += $"{i}, ";
            }
            vystup += $"{Environment.NewLine}Chyb�j�c� cifry: ";
            for (int i = 0; i < countDigit.Length; i++)
            {
                if (countDigit[i] == 0) vystup += $"{i}, ";
            }

            vystup += $"{Environment.NewLine}Nej�ast�j�� hodnota: ";
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
            vystup += $"Nejvy��� mo�n� ��slo:";
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