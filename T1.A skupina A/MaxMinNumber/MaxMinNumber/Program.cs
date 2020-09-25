using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // zadefinovaní datové struktury pole s nastavením jeho velikosti
            int[] poleCisel = new int[5];

            Console.WriteLine("Zadejte 5 cisel");

            // přidání hodnot do jednotlivých částí pole ze vstupu - náročný přístup (ukážeme si hezčí)
            poleCisel[0] = int.Parse(Console.ReadLine());
            poleCisel[1] = int.Parse(Console.ReadLine());
            poleCisel[2] = int.Parse(Console.ReadLine());
            poleCisel[3] = int.Parse(Console.ReadLine());
            poleCisel[4] = int.Parse(Console.ReadLine());

            // zadefinování proměnné pro maximum a minimum - a vložení hodnoty z 1. pozice pole
            int max = poleCisel[0];
            int min = poleCisel[0];

            // pro zbylé pozice testujeme pomocí if else podmínky pravdivost maxima a minima

            /*if( podmínka )
            {
               vykoná se pokud je podmínka splněna
            } 
            else
            {
               vykoná se pokud podmínka není splněna
            }*/

            if(poleCisel[1] > max)
            {
                max = poleCisel[1];
            }
            if(poleCisel[1] < min)
            {
                min = poleCisel[1];
            }
            // -------------------------
            if (poleCisel[2] > max)
            {
                max = poleCisel[2];
            }
            if (poleCisel[2] < min)
            {
                min = poleCisel[2];
            }
            // -------------------------
            if (poleCisel[3] > max)
            {
                max = poleCisel[3];
            }
            if (poleCisel[3] < min)
            {
                min = poleCisel[3];
            }
            // -------------------------
            if (poleCisel[4] > max)
            {
                max = poleCisel[4];
            }
            if (poleCisel[4] < min)
            {
                min = poleCisel[4];
            }
            // -------------------------

            // vypsaní maxima a minima na výstup
            // na pozici {0} se vypíše první argument a na pozici {1} druhý
            Console.WriteLine("Maximum je {0} a minumum je {1}", max, min);


        }
    }
}
