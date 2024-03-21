using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _19_Ponorka
{
    public class AnalyzaDat
    {
        List<Zaznam> data = new List<Zaznam>();
        public List<Zaznam> Data { get { return data; } }

        public AnalyzaDat(string cesta)
        {
            ZpracujData(cesta);
        }

        private void ZpracujData(string cesta)
        {
            using (StreamReader sr = new StreamReader(cesta))
            {
                sr.ReadLine(); // vycteni zahlavi
                while (!sr.EndOfStream)
                {
                    string radek = sr.ReadLine(); //"13;87;10"
                    //{"13","87","10"}
                    string[] rozdelenyRadek = radek.Split(";");
                    Zaznam z = new Zaznam(int.Parse(rozdelenyRadek[0]),
                                          Convert.ToInt32(rozdelenyRadek[1]),
                                          Convert.ToInt32(rozdelenyRadek[2]));
                    data.Add(z);
                }
                sr.Close();
            }
        }

        public string AnalyzaIntervalu(int zacatek, int konec)
        {
            if (konec > data.Count) return "nedostatek dat";
            if (konec < zacatek) return "neplatný interval";
            if (konec - zacatek < 1) return "malý interval";

            List<double> gradienty = new List<double>();
            for (int index = zacatek; index <= konec; index++)
            {
                double g = ((double)data[index + 1].Cas - data[index].Cas) /
                        ((double)data[index + 1].Hloubka - data[index].Hloubka);
                gradienty.Add(g);
            }

            double prumerGradientu = gradienty.Average();

            if (Math.Abs(prumerGradientu) < 0.0001) return "konsatní";

            if (prumerGradientu > 0) return "rostoucí";
            else return "klesající";
        }
    }

    public struct Zaznam
    {
        // cas, hloubka, tlak
        public int Hloubka { get; init; }
        public int Cas { get; init; }
        public int Tlak { get; init; }

        public Zaznam(int cas, int hloubka, int tlak)
        {
            Hloubka = hloubka;
            Cas = cas;
            Tlak = tlak;
        }


    }
}
