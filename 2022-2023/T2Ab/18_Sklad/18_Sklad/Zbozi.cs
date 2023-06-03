using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Sklad
{
    internal class Zbozi
    {
        private string nazev;
        private string jednotky;
        private double mnozstvi;

        public double Mnozstvi { set { mnozstvi += value; } }

        public Zbozi(string n, string j, double m)
        {
            nazev = n;
            jednotky = j;
            mnozstvi = m;
        }

        public override string ToString()
        {
            return $"{nazev} ({mnozstvi} {jednotky})";
        }
    }
}
