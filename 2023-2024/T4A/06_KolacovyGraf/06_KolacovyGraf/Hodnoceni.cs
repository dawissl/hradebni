using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_KolacovyGraf
{
    internal class Hodnoceni
    {
        private string predmet;
        private int sumaZnamek;
        private int pocetZnamek;

        public int SumaZnamek { set { sumaZnamek += value; } }
        public int PocetZnamek { set { pocetZnamek += value; } }
        public string Predmet { get { return predmet; } }

        public Hodnoceni(string p, int znamka)
        {
            predmet = p;
            sumaZnamek = znamka;
            pocetZnamek = 1;
        }

        public double Prumer()
        {
            return double.Round((double)sumaZnamek / pocetZnamek, 2);
        }

        public override string ToString()
        {
            return $"{predmet}: {Prumer()}";
        }

    }
}
