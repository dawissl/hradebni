using System.Drawing;

namespace _03_DlouheCislo
{
    /// <summary>
    /// Víceciferné èíslo získané od uživatele pøeveïte na pole èísel dle
    /// jednotlivých cifer. Následnì proveïte nad zadaným polem analýzu 
    /// s následujícím výstupem:
    ///     poèet sudých a lichých cifer vèetnì výpisu
    ///     nejèastìji se vyskytující cifra
    ///     vypsat chybìjící cifry
    /// Rozšíøení:
    ///     Pøeskládejte hodnoty pùvodního èísla tak, aby vzniklo nejvyšší možné èíslo
    ///     Vypište všechny jednociferné dìlitele pùvodního èísla
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            string vystup = $"Analýza vstupního èísla{Environment.NewLine}========================{Environment.NewLine}";
            int sude = 0;
            int liche = 0;

            string vstup = TxtLongNumber.Text;
            // pole do kterého vložíme pùvodní èíslo ze vstupu po cifrách
            int[] numberArr = new int[vstup.Length];
            // pole držící informaci, zda je cifra ve vstupním èísle obsažena
            // využíváme poznatku, že index pole odpovídá konkrétní ciføe
            // napø.: index 2 pole odpovídá ciføe 2
            // cifry jsou 0,1,2,3,4,5,6,7,8,9
            bool[] numberExist = new bool[10];
            // pomocné pole, ve kterém držíme informaci o poètu výskytù cifer
            int[] countNumber = new int[10];
            for (int i = 0; i < vstup.Length; i++)
            {
                // získání jedné cifry a vložení na pøíslušnou pozici v polii
                numberArr[i] = (int)Char.GetNumericValue(vstup[i]);
                numberExist[numberArr[i]] = true;
                countNumber[numberArr[i]]++;
                if ((numberArr[i] % 2) == 0)
                    sude++;
                else
                    liche++;

            }

            vystup += $"Sudá èísla: {sude} {{";
            // procházíme všechny sudé indexy (sudé cifry) zda jsou v èísle obsažena
            // z toho dùvodu je inkrement for cyklu o 2
            for (int i = 0; i < numberExist.Length; i += 2)
            {
                if (numberExist[i]) vystup += $"{i}, ";
            }
            vystup += $"}}{Environment.NewLine}Lichá èísla: {liche} {{";
            // procházíme všechny liché indexy (liché cifry) zda jsou v èísle obsažena
            // z toho dùvodu je inkrement for cyklu o 2
            for (int i = 1; i < numberExist.Length; i += 2)
            {
                if (numberExist[i]) vystup += $"{i}, ";
            }
            vystup += $"}}{Environment.NewLine}Chybìjící cifry: ";
            // pruchod celým polem informujícím o výskytu cifry, abychom mohli
            // vypsat chybìjící
            for(int i=0;i< numberExist.Length; i++)
            {
                if (!numberExist[i]) vystup += $"{i}, ";
            }
            vystup += $"{Environment.NewLine}";
            // nalezení nejèetnìjší cifry
            // využijem ukazatel na pozici který opìt odpovídá dané ciføe
            // pøi hledání maximální hodnoty (poèet výskytù) aktualizujeme
            // rovnìž index, kde se aktuální maximum nachází
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
            vystup += $"Nejèastìjší cifra: {index} {Environment.NewLine}";
            // vypsání nejvyšíího možného èísla z daných cifer
            // využijeme pole s výskytem cifer, které procházíme odzadu
            // hodnota v poli nám øíká, kolikrát danou cifru mám vypsat
            vystup += $"Nejvyššíí možné èíslo: ";
            for (int i=countNumber.Length-1; i >= 0; i--)
            {
                while (countNumber[i] > 0)
                {
                    vystup += $"{i}";
                    countNumber[i]--;
                }
            }

            //vypsání jednociferných dìlitelù pùvodního èísla
            vystup += $"{Environment.NewLine}Dìlitelé: ";
            for(int i = 2; i <= 9; i++)
            {
                if (long.Parse(vstup) % i == 0) vystup += $"{i}, ";
            }
           

            TxtResult.Text = vystup;
        }
    }
}