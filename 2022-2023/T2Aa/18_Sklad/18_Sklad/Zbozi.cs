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

        public Zbozi(string nazev, string jednotky, double mnozstvi)
        {
            this.nazev = nazev;
            this.jednotky = jednotky;
            this.mnozstvi = mnozstvi;
        }

        public override string ToString()
        {
            return $"{nazev} ({mnozstvi} {jednotky})";
        }
    }
}
