using System;
// -../.-/.--/../...
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FixCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oprava cizího kódu - chyby mohou být logické i syntaktické:");
            Console.WriteLine("A - Počítadlo jedniček");
            Console.WriteLine("B - Bublinkové řazení");
            Console.WriteLine("C - Změna čísla v cyklu");
            Console.WriteLine("--------------------------------------------------------------");
            Console.Write("Zadejte písmeno pro volbu aplikace:");
            string option = Console.ReadLine();
            Console.WriteLine("==============================================================");
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
                default:
                    Console.WriteLine("Neznámé zadání");
                    break;
            }

        }

        /// <summary>
        /// Funkce s chybou (3 řádky s chybou)
        /// </summary>
        private static void AlgorithmA()
        {
            Console.WriteLine("A - Počítadlo jedniček");

            string veta = "21876365711910233341";
            Console.WriteLine("Vstupní řetězec s čísly je: {0}", veta);
            // pokud chceme něco počítat není chytré mít výchozí hodnotu počítadla 1
            //int pocet = 1;
            int pocet = 0; 
            // konstrukce for cyku odděluje jednotlivé příkazy pomocí středníku (;) nikoliv čárky (,)
            //for (int i = 0, i < veta.Length, i++)
            for (int i = 0; i < veta.Length; i++)
            {
                string znak = veta.Substring(i, 1);
                // skrytá chyba, která je špatně z doporučení, program je ovšem funkční i bez její opravy
                //if (int.Parse(znak) == 1) { pocet++; }
                if (double.Parse(znak) == 1) { pocet++; }
            }



            Console.WriteLine("V řetězci se nachází {0} jedniček.", pocet);
        }

        /// <summary>
        /// Funkce s chybou (2 řádky s chybou)
        /// </summary>
        private static void AlgorithmB()
        {
            Console.WriteLine("B - Bublinkové řazení");

            int[] arr = { 3, 2, 8, 7, 6 };
            // pokus o vypsání hodnty na pozici pole[5], která neexistuje
            // pole indexujeme od 0 a nejvyšší index v poli o velikosti 5 je tedy 4, pole[4]
            // Console.WriteLine("Neserazene pole: {0}, {1}, {2}, {3}, {4}", arr[1], arr[2], arr[3], arr[4], arr[5]);
            Console.WriteLine("Neserazene pole: {0}, {1}, {2}, {3}, {4}", arr[0], arr[1], arr[2], arr[3], arr[4]);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        int tmp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            // uvedením formátu {0} značíme, že na 0. parametru bude vypsaná hodnota
            // číslem X v {X} určujeme, kolikátý parametr chceme vypsat
           // Console.WriteLine("Serazene pole: {0}, {0}, {0}, {0}, {0}", arr[0], arr[1], arr[2], arr[3], arr[4]);
            Console.WriteLine("Serazene pole: {0}, {1}, {2}, {3}, {4}", arr[0], arr[1], arr[2], arr[3], arr[4]);

        }

        /// <summary>
        /// Funkce s chybou (3 řádky s chybou)
        /// </summary>
        private static void AlgorithmC()
        {
            Console.WriteLine("C - Změna čísla v cyklu");

            // int cislo = Math.PI
            double cislo = Math.PI; // desetinné číslo nelze ukládat jako int 

            // while (cislo >= -1.25) ;
            while (cislo >= -1.25) // přebývající středník za podmínkou u while cyklu
            {
                Console.WriteLine("Číslo má hodnotu: {0}", cislo);
                if (Math.Round(cislo) > 3)
                {
                    cislo -= 0.26;
                }
                else
                {
                    cislo *= 0.6;
                }

                if ((Math.Floor(cislo) % 3) > 2)
                {
                    cislo += 7.8;
                }
                else
                {
                    cislo *= -1.3;
                }
            }
            // chybějící čárka za vypisovaným řetězcem před uvedením parametrů
           // Console.WriteLine("Číslo má hodnotu: {0}" cislo);
            Console.WriteLine("Číslo má hodnotu: {0}", cislo);


        }




    }
}
