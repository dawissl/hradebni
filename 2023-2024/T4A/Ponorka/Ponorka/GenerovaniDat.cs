using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponorka
{
    internal class GenerovaniDat
    {
        private string cesta;

        public GenerovaniDat(string c)
        {
            cesta = c;
            VyblijMiSoubor();
        }

        private void VyblijMiSoubor()
        {
            using(StreamWriter sw = new StreamWriter(cesta))
            {
                // zápis záhlaví souboru
                sw.WriteLine("Time;Depth");
                Random random = new Random();
                // nahodne vytvorime <100;150> zaznamu
                int pocetZaznamu = random.Next(100,151);                
                for(int i = 1; i <= pocetZaznamu; i++)
                {
                    // zanesení chyby, v jednom z peti pripadu neprovedeme zápis
                    if (random.Next(0, 5) == 0) continue; 
                    int hloubka = random.Next(50, 251); // vygenerování náhodné hodnoty
                    sw.WriteLine($"{i};{hloubka}"); // zápis do souboru s použitím formátovaného řetězce
                }
                sw.Close();
            }
        }
    }
}
