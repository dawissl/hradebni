using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozdraveniUzivatele
{
    class Program
    {
        static void Main(string[] args)
        {
            // zadefinovani string proměnné pro jmeno (string = očekáváme řetězec)
            string jmeno;
            // zadefinovani proměnné věku (int = celočíselná hodnota)
            int vek;
            
            // Console.WriteLine(" Obash textu") - výpis na standardní výstup - konzoli
            Console.WriteLine("Zadejte svoje jméno");

            // Console.ReadLine() - načtení řádku ze vstupu, je nám vrácen string není potřeba konverze
            jmeno = Console.ReadLine();
                    
            // výpis na vstup - využití spojení řetězců pomocí +
            Console.WriteLine("Ahoj " + jmeno + " kolik Ti je let?");

            //Console.ReadLine() nám vrací string a je tedy nutné z řetězce hodnotu získat pomocí Parse()
            vek = int.Parse(Console.ReadLine());

            Console.WriteLine("Cože? Tobě už je " + vek + " to jsem nečekalo.");
            
            
        }
    }
}


