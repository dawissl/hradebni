using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Who_prakitcka
{
    internal class Pricina
    {
        private string nazev;
        private int pocetVyskytu = 1;

        public string Nazev { get { return nazev; } }
        public int PocetVyskytu
        {
            get { return pocetVyskytu; }
            set { pocetVyskytu += value; }
        }

        public Pricina(string pricina)
        {
            nazev = pricina.ToUpper();
        }

        public override string ToString()
        {
            return $"{nazev}, počet výskytů: {pocetVyskytu}";
        }
    }
}
