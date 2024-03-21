using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Ponorka
{
    internal class GeneratorSouboru
    {
        private string nazevSouboru;

        public GeneratorSouboru(string nazev)
        {
            nazevSouboru = nazev;
            VytvorDatovySoubor();
        }

        private void VytvorDatovySoubor()
        {
            using (StreamWriter sw = new StreamWriter(nazevSouboru))
            {
                sw.WriteLine("čas;hloubka;tlak");
                Random rnd = new Random();
                int pocetZaznamu = rnd.Next(50,200);
                for(int time = 1; time <= pocetZaznamu; time++)
                {
                    int value = rnd.Next(100, 251);
                    int pressure = rnd.Next(1, 11);
                    sw.WriteLine($"{time};{value};{pressure}");
                }       
                sw.Close();
            }
        }
    }
}
