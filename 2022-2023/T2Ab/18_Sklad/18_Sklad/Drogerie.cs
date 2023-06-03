using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Sklad
{
    internal class Drogerie : Zbozi
    {
        private string omezeni;

        public Drogerie(string n, string m, double j, string o) : base(n, m, j)
        {
            omezeni = o;
        }
    }
}
