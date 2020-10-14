using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // již standardní deklarace proměnných a jejich načtení z konzole
            int a, b, c;
            Console.WriteLine("Program pro zjištění obvodu trojúhelníku ze zadaných přímek");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.Write("Zadejte stranu a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Zadejte stranu b:");
            b = int.Parse(Console.ReadLine());
            Console.Write("Zadejte stranu c:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Načtení stran dokončeno");

            // zanoření podmínek
            // pokud je první podmínka splněná, musíme testovat i nasledující podmínky
            // proto je obsahem bloku pro kladnou větev další podmínka.
            // Nesmíme ovšem zapomenout na to, že kdykoliv není některá z podmínek splněná
            // vypisujeme na výstup informaci o nemožnosti sestrojení trojúhelníku

            if (a + b > c)
            { // 1. podmínka začátek bloku, pokud je podmínka splněna
                if (a + c > b)
                { // 2. podmínka začátek bloku, pokud je podmínka splněna
                    if (b + c > a)
                    { // 3. podmínka začátek bloku, pokud je podmínka splněna -> výpočet obvodu
                        int obvod = a + b + c;
                        Console.WriteLine("Obvod trojúhelníku je {0}", obvod);
                    }// 3. podmínka konec bloku pro +
                    else
                    {// 3. podmínka začátek bloku, pokud podmínka není splněna
                        Console.WriteLine("Trojúhelník nelze sestrojit");
                    }// 3. podmínka konce bloku pro -
                }// 2. podmínka konec bloku pro +
                else
                {// 2. podmínka začátek bloku, pokud podmínka není splněna
                    Console.WriteLine("Trojúhelník nelze sestrojit");
                }// 2. podmínka konce bloku pro -
            } // 1. podmínka konec bloku pro +
            else
            { // 1. podmínka začátek bloku, pokud podmínka není splněna
                Console.WriteLine("Trojúhelník nelze sestrojit");
            } // 1. podmínka konce bloku pro -


            // pokročilejší varianta řešení za pomocí využití nově deklarované funkce
            // deklarace pravdivostní proměnné de které přiřadíme výsledek z vytvořené funkce
            bool check = TriangleCheck(a, b, c);
            if (check) // check je pravdivostní hodnota a můžeme ji použit pro rozhodnutí, zda 
                       // zda je podmínka splněna                  
            {
                Console.WriteLine("Obvod trojúhelníku je {0}", a + b + c);
            }
            else
            {
                Console.WriteLine("Trojúhelník nelze sestrojit");
            }



        }

        // funkce, která rozhodna, zda lze sestrojit trojúhelník
        // na vstupu očekává 3 celočíselné hodnoty a vrací pravdivostní bool hodnotu
        private static bool TriangleCheck(int a, int b, int c)
        {
            // pokud je pravda, že součet dvou stran je menší než délka třetí není třeba testovat
            // další podmínky a pomocí klíčového slova return vrátíme false;
            if (a + b < c) return false;
            if (a + c < b) return false;
            if (b + c < a) return false;
            // pokud není ani jedna z podmínek splněná, znamená to, že trojúhelník lze vytvořit
            // vracíme true
            return true;
        }
    }
}


