using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProhozeniPromennych
{
    class Program
    {
        // hlavní tělo programu označujeme jako Main funkci
        static void Main(string[] args)
        {
            // deklarace proměnných, do kterých později uložíme hodnoty
            int a;
            int b;

            //infomrace pro uživatel, co má udělat. Text, který chceme vložit vkládáme do uvozovek "TEXT"
            Console.WriteLine("Vložte dvě čísla:");
            // nacteni a pretransformování proměnných zadané uživatelem bez kontroly vstupu
            // funkce Console.ReadLine() přečte celý řádek ukončený pomocí ENTER
            // funkce int.Parse() se snaží ze zadaného vstupu typu string vytvořit celé int číslo
            // využívám vnoření funkcí -> nejprve se provedou všechny vnitřní funkce a následně vnější
            // výsledek vnitřní funkce je použit jako vstupní argument pro funkci vnější
            a = int.Parse(Console.ReadLine()); 
            b = int.Parse(Console.ReadLine());

            // deklarace pomocné proměnné
            int tmp;
            // prohození hodnot
            tmp = a;
            a = b;
            b = tmp;

            // Vypsaní prohozených proměnných na výstup
            Console.WriteLine("Prohozenné proměnné:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            //program spouštíme pomocí ctrl + F5, aby se po konci provedení všech kroků nezavřela konzole
        }
    }
}
