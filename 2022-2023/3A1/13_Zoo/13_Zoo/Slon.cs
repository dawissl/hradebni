using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Zoo
{
    internal class Slon : Zvire
    {

        private int vaha;
        private int chobot;

        public Slon(string jmeno, int vek, int zdravi, int vaha, int chobot) : base(jmeno, vek, zdravi)
        {
            this.vaha = vaha;
            this.chobot = chobot;
        }

        public string Zatrub()
        {
            return "Tuuuuuuu!";
        }
    }
}
