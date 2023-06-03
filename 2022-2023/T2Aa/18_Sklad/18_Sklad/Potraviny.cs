using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Sklad
{
    internal class Potraviny : Zbozi
    {
        private string trvanlivost;

        public Potraviny(string nazev, string jednotky, double mnozstvi, string trvanlivost)
            : base(nazev, jednotky, mnozstvi)
        {
            this.trvanlivost = trvanlivost;
        }
    }
}
