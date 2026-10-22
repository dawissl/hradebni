using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Katalog
{
    public class Polozka
    {
        private string nazev;
        private int pocet;
        private string popis;


        public override string ToString()
        {

            return $"{nazev} ({pocet})";

        }
        public Polozka(string nazev, int pocet, string popis) 
        {
            this.nazev = nazev ;
            this.pocet = pocet ;
            this.popis = popis ;
        }

    }
}
