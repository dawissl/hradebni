using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Zoo
{
    internal class Slon : Zvire
    {
        private string druh;

        public Slon(string jmeno, int vek, int zdravi, string druh) : base(jmeno, vek, zdravi)
        {
            this.druh = druh;
        }
    }
}
