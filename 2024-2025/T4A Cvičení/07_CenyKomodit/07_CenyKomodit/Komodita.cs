using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CenyKomodit
{
    public class Komodita
    {
        private string nazev;
        private List<Polozka> data;

        public List<Polozka> Data { get { return data; } }
        public string Nazev { get { return nazev; } }
        public Komodita(string nazev)
        {
            this.nazev = nazev;
            data = new List<Polozka>();
        }
        public List<int> CenyPolozek()
        {
            return new List<int>();
        }
        public List<int> CenyPolozek(DateTime odData)
        {
            return new List<int>();
        }
        public List<int> CenyPolozek(DateTime odData, DateTime doData)
        {
            return new List<int>();
        }

    }

    public struct Polozka
    {
        public DateTime Datum { get; set; }
        public double Cena { get; set; }       
            
        
    }
}
