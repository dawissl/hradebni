using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarace datové struktury pole s určením, jak velké pole vytváříme
            int[] pole = new int[5];

            // využití cyklu s pevným počtem opakování pro načtení hodnot do deklarovaného pole
            // for ( definování řídící proměnné; definování intervalu; co se má s proměnnou stát na konci cyklu)
            for (int i = 0; i < 5; i++)
            {
                pole[i] = int.Parse(Console.ReadLine());
            }

            // deklarace maxima a přiřazení hodnoty z 1. pozice pole
            int max = pole[0];
            // rozhodnutí podmínek pro určení maxima a minima - lze zjednodušit pomoci for cyklu
            /* if( podminka) {
                provede se pokud je podmínka splněna
               } else {
                provede se pokud neni splněná podmínka
              }
            */
            
            if (pole[1] > max)
            {
                max = pole[1];
            }
            if (pole[2] > max)
            {
                max = pole[2];
            }
            if (pole[3] > max)
            {
                max = pole[3];
            }
            if (pole[4] > max)
            {
                max = pole[4];
            }

            //výpis na výstup

            Console.WriteLine(max);
        }
    }
}
