using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_KolacovyGraf
{
    internal class Osoba
    {
      
        private string jmeno;     
        private int pocet;
        private int vek;

       public int Pocet { get { return pocet; } set { pocet+=value; } }
        public string Jmeno { get { return jmeno; } }
        public int Vek { get { return vek; } }

        public Osoba(string j, int v)
        {
            jmeno = j;
            vek = v;
            pocet = 1;
        }

        public Osoba(string j)
        {
            jmeno = j;
            vek = 1;
            pocet = 1;
        }

        public override string ToString()
        {
            return $"{jmeno}-{pocet}";
        }
    }
}
