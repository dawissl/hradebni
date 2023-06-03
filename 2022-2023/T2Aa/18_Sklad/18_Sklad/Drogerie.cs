using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _18_Sklad
{
    internal class Drogerie : Zbozi
    {
        private string omezeni;

        public Drogerie(string jmeno, string jednotky, double mnozstvi, string omezeni)
            : base(jmeno, jednotky, mnozstvi)
        {
            this.omezeni = omezeni;
        }
    }
}
