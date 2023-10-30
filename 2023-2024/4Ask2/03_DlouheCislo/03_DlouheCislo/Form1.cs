using System.Drawing;

namespace _03_DlouheCislo
{
    /// <summary>
    /// V�cecifern� ��slo z�skan� od u�ivatele p�eve�te na pole ��sel dle
    /// jednotliv�ch cifer. N�sledn� prove�te nad zadan�m polem anal�zu 
    /// s n�sleduj�c�m v�stupem:
    ///     po�et sud�ch a lich�ch cifer v�etn� v�pisu
    ///     nej�ast�ji se vyskytuj�c� cifra
    ///     vypsat chyb�j�c� cifry
    /// Roz���en�:
    ///     P�eskl�dejte hodnoty p�vodn�ho ��sla tak, aby vzniklo nejvy��� mo�n� ��slo
    ///     Vypi�te v�echny jednocifern� d�litele p�vodn�ho ��sla
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            string vystup = $"Anal�za vstupn�ho ��sla{Environment.NewLine}========================{Environment.NewLine}";
            int sude = 0;
            int liche = 0;

            string vstup = TxtLongNumber.Text;
            // pole do kter�ho vlo��me p�vodn� ��slo ze vstupu po cifr�ch
            int[] numberArr = new int[vstup.Length];
            // pole dr��c� informaci, zda je cifra ve vstupn�m ��sle obsa�ena
            // vyu��v�me poznatku, �e index pole odpov�d� konkr�tn� cif�e
            // nap�.: index 2 pole odpov�d� cif�e 2
            // cifry jsou 0,1,2,3,4,5,6,7,8,9
            bool[] numberExist = new bool[10];
            // pomocn� pole, ve kter�m dr��me informaci o po�tu v�skyt� cifer
            int[] countNumber = new int[10];
            for (int i = 0; i < vstup.Length; i++)
            {
                // z�sk�n� jedn� cifry a vlo�en� na p��slu�nou pozici v polii
                numberArr[i] = (int)Char.GetNumericValue(vstup[i]);
                numberExist[numberArr[i]] = true;
                countNumber[numberArr[i]]++;
                if ((numberArr[i] % 2) == 0)
                    sude++;
                else
                    liche++;

            }

            vystup += $"Sud� ��sla: {sude} {{";
            // proch�z�me v�echny sud� indexy (sud� cifry) zda jsou v ��sle obsa�ena
            // z toho d�vodu je inkrement for cyklu o 2
            for (int i = 0; i < numberExist.Length; i += 2)
            {
                if (numberExist[i]) vystup += $"{i}, ";
            }
            vystup += $"}}{Environment.NewLine}Lich� ��sla: {liche} {{";
            // proch�z�me v�echny lich� indexy (lich� cifry) zda jsou v ��sle obsa�ena
            // z toho d�vodu je inkrement for cyklu o 2
            for (int i = 1; i < numberExist.Length; i += 2)
            {
                if (numberExist[i]) vystup += $"{i}, ";
            }
            vystup += $"}}{Environment.NewLine}Chyb�j�c� cifry: ";
            // pruchod cel�m polem informuj�c�m o v�skytu cifry, abychom mohli
            // vypsat chyb�j�c�
            for(int i=0;i< numberExist.Length; i++)
            {
                if (!numberExist[i]) vystup += $"{i}, ";
            }
            vystup += $"{Environment.NewLine}";
            // nalezen� nej�etn�j�� cifry
            // vyu�ijem ukazatel na pozici kter� op�t odpov�d� dan� cif�e
            // p�i hled�n� maxim�ln� hodnoty (po�et v�skyt�) aktualizujeme
            // rovn� index, kde se aktu�ln� maximum nach�z�
            int index = 0;
            int max = countNumber[index];
            for(int i = 1; i < countNumber.Length; i++)
            {
                if (countNumber[i] > max)
                {
                    max = countNumber[i];
                    index = i;
                }
            }
            vystup += $"Nej�ast�j�� cifra: {index} {Environment.NewLine}";
            // vyps�n� nejvy���ho mo�n�ho ��sla z dan�ch cifer
            // vyu�ijeme pole s v�skytem cifer, kter� proch�z�me odzadu
            // hodnota v poli n�m ��k�, kolikr�t danou cifru m�m vypsat
            vystup += $"Nejvy���� mo�n� ��slo: ";
            for (int i=countNumber.Length-1; i >= 0; i--)
            {
                while (countNumber[i] > 0)
                {
                    vystup += $"{i}";
                    countNumber[i]--;
                }
            }

            //vyps�n� jednocifern�ch d�litel� p�vodn�ho ��sla
            vystup += $"{Environment.NewLine}D�litel�: ";
            for(int i = 2; i <= 9; i++)
            {
                if (long.Parse(vstup) % i == 0) vystup += $"{i}, ";
            }
           

            TxtResult.Text = vystup;
        }
    }
}