using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Ponorka
{
    public class GeneratorDat
    {
        private string cestaSoubor;

        public GeneratorDat(string cesta)
        {
            cestaSoubor = cesta;
            VytvorData();
        }

        private void VytvorData()
        {
            // casovaZnamka;hloubka
            Random r = new Random();
            int pocetZaznamu = r.Next(50, 201);

            using (StreamWriter sw = new StreamWriter(cestaSoubor))
            {
                sw.WriteLine("cas;hloubka;tlak");
                for (int i = 0;i < pocetZaznamu;i++)
                {
                    if (r.Next(0, 5) == 0) continue;
                    sw.WriteLine($"{i+1};{r.Next(50,101)};{r.Next(0,11)}");
                }
                sw.Close();
            }
            MessageBox.Show($"Soubor {cestaSoubor} byl vygenerován");
        }
    }
}
