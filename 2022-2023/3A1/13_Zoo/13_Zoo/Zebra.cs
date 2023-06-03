using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Zoo
{
    internal class Zebra : Zvire
    {
        private int bilePruhy;
        private int cernePruhy;

        public Zebra(string jmeno, int vek, int zdravi, int bp, int cp) : base(jmeno, vek, zdravi)
        {
            bilePruhy = bp;
            cernePruhy = cp;
        }

        public string Bez()
        {
            return "Yeeeeha!";
        }
    }
}
