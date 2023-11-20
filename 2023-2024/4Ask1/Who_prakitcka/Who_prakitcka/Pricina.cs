using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Who_prakitcka
{
    internal class Pricina
    {
        private string onemocneni;
        private int pocet_vyskytu = 1;

        public string Onemocneni { get { return onemocneni; } }
        public int PocetVyskytu { get { return pocet_vyskytu; } set { pocet_vyskytu++; } }

        public Pricina(string o)
        {
            onemocneni = o.ToUpper();
        }

        public override string ToString()
        {
            return $"{onemocneni}, počet výskytů: {pocet_vyskytu}";
        }
    }
}
