using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Ponorka
{
    public class AnalyzatorDat
    {
        List<Zaznam> data = new List<Zaznam>();

        public List<Zaznam> Data { get { return data; } }

        public AnalyzatorDat(string cestaSoubor)
        {
            ZpracujData(cestaSoubor);
        }

        private void ZpracujData(string cestaSoubor)
        {
            using (StreamReader sr = new StreamReader(cestaSoubor))
            {
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    // 13;121;6
                    string radek = sr.ReadLine();
                    // {"13","121","6"}
                    string[] rozdelenyRadek = radek.Split(";");
                    Zaznam z = new Zaznam(Convert.ToInt32(rozdelenyRadek[0]),
                                          int.Parse(rozdelenyRadek[1]),
                                          int.Parse(rozdelenyRadek[2]));
                    data.Add(z);
                }
                sr.Close();
            }
        }

        public string AnalyzaIntervalu(int zacatek, int konec)
        {
            if (konec < zacatek) return "neplatný interval";
            if (konec - zacatek < 1) return "nedostatečný interval";
            List<double> gradienty = new List<double>();

            // postupný výpočet gradientu mezi jednotlivými body
            for (int index = zacatek; index <= konec; index++)
            {
                double g = (data[index + 1].Hloubka - data[index].Hloubka) /
                            (data[index + 1].Cas - data[index].Cas);
                gradienty.Add(g);
            }

            // očekávaná chyba výpočtu
            if (Math.Abs(gradienty.Average()) < 0.001) return "konstatní";

            if (gradienty.Average() > 0)
                return "rostoucí";
            else
                return "klesající";

        }
    }

    public struct Zaznam
    {
        public int Cas { get; init; }
        public int Hloubka { get; init; }
        public int Tlak { get; init; }

        public Zaznam(int cas, int hloubka, int tlak)
        {
            Cas = cas;
            Hloubka = hloubka;
            Tlak = tlak;
        }

        public override string ToString()
        {
            return $"{Cas}, {Hloubka}, {Tlak}";
        }


    }
}
