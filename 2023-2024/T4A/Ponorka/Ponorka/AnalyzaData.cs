using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponorka
{
    internal class AnalyzaData
    {
        
        private List<Zaznam> data = new List<Zaznam>();
        // zpristupnení datove kolekce pro čtení
        public List<Zaznam> Data { get { return data; } }
        public AnalyzaData(string cesta)
        {
            NactiData(cesta);
        }

        private void NactiData(string cesta)
        {
            using (StreamReader sr = new StreamReader(cesta))
            {
                sr.ReadLine(); // prázdné vyčtení záhlaví, které neobsahuje data
                while (!sr.EndOfStream) //čteme dokud nedojdeme na konec souboru
                {
                    string radek = sr.ReadLine();// "13;165"
                    string[] rozdelenyRadek = radek.Split(";"); //{"13","165"}
                    // dvě možnosti konvereze string -> int 
                    Zaznam z = new Zaznam(int.Parse(rozdelenyRadek[0]),
                                          Convert.ToInt32(rozdelenyRadek[1]));
                    data.Add(z);
                }
                sr.Close();
            }
        }

        public string AnalyzaIntervalu(int zacatek, int konec)
        {
            // kontrola nevalidních vstupních hodnot
            if (konec < zacatek) return "neplatný interval";
            if (konec > data.Count) return "nedostatek dat";
            if (konec == zacatek) return "kratký interval";

            // kolekce kam budeme postupně přidávat vypočtené gradienty
            List<double> gradienty = new List<double>();

            for (int i = zacatek; i <= konec; i++)
            {
                // vypočet gradientu mezi dvěma body na pozicih (i+1) a i 
               
                double g = ((double)data[i + 1].Cas - data[i].Cas) /
                    (data[i + 1].Hloubka - data[i].Hloubka);
                gradienty.Add(g);
            }
            // chceme získat hodnotu prumerneho gradientu
            double prumerGradientu = gradienty.Average();
            // pokud je číslo dostatečně malé, prohlásíme jej za nulové
            if (Math.Abs(prumerGradientu) < 0.0001) return "konstantí";
            if (prumerGradientu > 0) 
                return "rostouci";
            else
                return "klesajici";

        }

        public Point[] hodnotyNad200()
        {
            // kombinace LINQ s lambda funkci
            List<Zaznam> filter = data.FindAll(x => x.Hloubka > 200);
            Point[] body = new Point[filter.Count];

            for(int i=0;i < filter.Count; i++)
            {
                // priprava bodu, které chceme vykreslit na krivce
                body[i] = new Point(filter[i].Cas * 5, filter[i].Hloubka);
            }
            return body;
        }
    }

    public struct Zaznam
    {
        public int Cas { get; init; }
        public int Hloubka { get; init; }

        public Zaznam(int c, int h)
        {
            Cas = c;
            Hloubka = h;
        }
    }
}