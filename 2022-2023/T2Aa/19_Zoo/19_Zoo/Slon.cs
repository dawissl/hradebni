using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Zoo
{
    internal class Slon: Zvire
    {
        Lokace typ;

        public Slon(string jmeno, int vek, int zdravi, Lokace puvod) : base(jmeno,vek, zdravi)
        {
            typ = puvod;
        }

        public void Stehovani()
        {
            if(typ == Lokace.AFRICKY)
            {
                typ = Lokace.INDICKY;
            }
            else
            {
                typ = Lokace.AFRICKY;
            }
        }
    }

    public enum Lokace { INDICKY, AFRICKY};
}
