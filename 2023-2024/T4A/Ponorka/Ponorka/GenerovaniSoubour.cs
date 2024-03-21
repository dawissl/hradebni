using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponorka
{
    internal class GenerovaniSoubour
    {
        public GenerovaniSoubour(string name)
        {
            createFile(name);
        }

        private void createFile(string name)
        {
            using (StreamWriter streamWriter = new StreamWriter(name))
            {
                streamWriter.WriteLine($"casova znamka;hloubka ponoru{Environment.NewLine}");
                Random r = new Random();
                for (int i = 0; i < 100; i++)
                {
                    if (r.Next(0, 101) < 20) continue;
                    streamWriter.WriteLine($"{i + 1};{r.Next(50, 251)}");
                }
                streamWriter.Close();
            }
            MessageBox.Show("Soubor vygenerován");
        }
    }
}
