using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Who_prakticka
{
    internal class Pricina
    {
        private string onemocneni;
        private int pocetVyskytu = 1;

        public string Onemocneni { get { return onemocneni; } }
        public int PocetVyskytu { get { return pocetVyskytu; } set { pocetVyskytu += value; } }

        public Pricina(string nemoc)
        {
            onemocneni = nemoc.ToUpper();
        }

        public override string ToString()
        {
            return $"{Onemocneni}, počet výskytů: {PocetVyskytu}";
        }

    }
}
