using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Poznamky
{
    internal class Ukol : Poznamka
    {
        private DateTime datumPlneni;

        public Ukol(string nadpis, string stitek, DateTime datumPlneni) : base(nadpis, stitek)
        {
            this.datumPlneni = datumPlneni;
        }

        public Ukol(string nadpis, DateTime datumPlneni) : base(nadpis)
        {
            this.datumPlneni = datumPlneni;
        }
    }
}
