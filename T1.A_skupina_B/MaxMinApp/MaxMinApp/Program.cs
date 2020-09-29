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
            // deklarace datové struktury pole a určení jeho velikosti
            int[] pole = new int[5];

            Console.WriteLine("Zadejte 5 čísel:");


            //využití cyklu s pevným počtem opakování pro načtení hodnot do pole
            for (int i=0; i < 5; i++)
            {
                pole[i] = int.Parse(Console.ReadLine());
            }


            //tento způsob je náročný a nebudeme jej používat
           // pole[0] = int.Parse(Console.ReadLine());
           // pole[1] = int.Parse(Console.ReadLine());
           // pole[2] = int.Parse(Console.ReadLine());
           // pole[3] = int.Parse(Console.ReadLine());
           // pole[4] = int.Parse(Console.ReadLine());

            //deklarace maxima a minima a zadání provtních hodnot z 1. pozice pole
            int max = pole[0];
            int min = pole[0];


            // opět využijeme cyklus s pevným počtem opakování - cyklus začíná od 1, protože na indexu 0
            // již máme uloženou hodnotu max a bylo by tak zbytečně je porovnávat
            for(int i= 1 ;i<5;i++)
            {
                // rozhodnutí podmínky
                if (pole[i] > max)
                {
                    max = pole[i];
                }
                if (pole[i] < min)
                {
                    min = pole[i];
                }
            }

            /*
              if (podminka)
              {
                provede se pokud je podminka splněna
              }
              else
              {
               provede se pokud podmínka není splněna
              }
             */

            // dvě možnosti, jak vypsat na výstup maximum a minimum
            // sloučení řetězců
            Console.WriteLine("Maximum = " + max + " a minimum = " + min);
            //vypsání argumentů
            Console.WriteLine("Maximum = {0} a minimum = {1}", max, min);
        }
    }
}
