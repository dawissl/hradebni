using Microsoft.SqlServer.Server;
// -../.-/.--/../...
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementace algoritmů II");
            Console.WriteLine("A - Určení počtu sudých a lichých čísel v poli");
            Console.WriteLine("B - Snižování čísla o 3,14");
            Console.WriteLine("C - Výpis hvězdiček ***");
            Console.WriteLine("D - Výška válce");
            Console.WriteLine("-----------------------------------------------------------");
            Console.Write("Zadejte písmeno pro volbu aplikace:");
            string option = Console.ReadLine();
            Console.WriteLine("===========================================================");
            switch (option)
            {
                case "A":
                case "a":
                    AlgorithmA();
                    break;
                case "B":
                case "b":
                    AlgorithmB();
                    break;
                case "C":
                case "c":
                    AlgorithmC();
                    break;
                case "D":
                case "d":
                    AlgorithmD();
                    break;
                default:
                    Console.WriteLine("Neznámé zadání");
                    break;
            }


        }

        /// <summary>
        /// Určete kolik čísel načtených do pole o velikosti 5 je sudých a kolik jich je lichých
        /// </summary>
        private static void AlgorithmA()
        {
            int sude = 0;
            int liche = 0;

            int[] poleCisel = new int[5];

            Console.WriteLine("Načti 5 čísel:");

            // TODO - načtení čísel ze vstupu a uložení do pole
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Načti {0}. číslo:", i + 1);
                poleCisel[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if ((poleCisel[i] % 2) == 0)
                {
                    // TODO - zvýšení počítadla pro sudá čísla
                    sude++;
                }
                else
                {
                    // TODO - zvýšení počítadla pro lichá čísla
                    liche++;
                }
            }

            Console.WriteLine("V poli je {0} čísel sudých a {1} čísel lichých", sude, liche);

        }

        /// <summary>
        /// Snižování vstupního čísla o hodnotu 3,14 doku není záporné. Pokud je číslo záporné vypište jej
        /// </summary>
        private static void AlgorithmB()
        {

            Console.Write("Vlož číslo: ");
            double cislo = double.Parse(Console.ReadLine());

            // TODO - kód, který bude snižovat číslo (využití cyklu s neznámým počtem opakování)
            while (cislo >= 0)
            {
                cislo = cislo - 3.14;
            }

            Console.WriteLine("Číslo je již záporné a má hodnotu {0}", cislo);
        }

        /// <summary>
        /// Vypsání tolik hvězdiček, jaký je počet výsledku A%B (zbytek po dělení)
        /// </summary>
        private static void AlgorithmC()
        {
            Console.WriteLine("Zadejte hodnoty A a B:");
            Console.Write("A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int B = int.Parse(Console.ReadLine());
            int pocet = A % B;
            Console.WriteLine("Výpis hvězdiček:");

            // TODO - vypsání tolik hvězdiček * jaký je výsledek (cyklus s pevným počtem opakování)
            string hvezdy = "";
            for (int i = 0; i < pocet; i++)
            {
                hvezdy += "*";
            }
            Console.WriteLine(hvezdy);

        }

        /// <summary>
        /// Určení výšky válce
        /// </summary>
        private static void AlgorithmD()
        {
            Console.WriteLine("Jak velká musí být výška válcové nádoby, aby měla určitý objem?");
            Console.Write("Požadovaný objem:");
            double objem = double.Parse(Console.ReadLine());
            Console.Write("Poloměr podstavy (r):");
            double polomer = double.Parse(Console.ReadLine());
            double vyska = 0;

            // konstanta PI z knihovny
            double pi = Math.PI;

            // TODO - určení výšky válce
            vyska = objem / (pi * polomer * polomer);

            Console.WriteLine("Válec o objemu {0} a poloměru {1} má výšku {2}", objem, polomer, vyska);

        }
    }
}
