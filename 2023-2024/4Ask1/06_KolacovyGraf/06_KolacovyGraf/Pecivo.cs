using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_KolacovyGraf
{
    internal class Pecivo
    {
        private string druh;
        private int pocet;

        public string Druh { get { return druh; }  }
        public int Pocet { get { return pocet; } set { pocet += value; } }

         public Pecivo(string d)
        {
            druh = d;            
        }

        public Pecivo(string d, int p)
        {
            druh = d;
            pocet = p;
        }

        public override string ToString()
        {
            return $"{druh}/{pocet}";
        }
    }
}
