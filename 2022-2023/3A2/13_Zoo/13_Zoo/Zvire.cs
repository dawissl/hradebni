using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Zoo
{
    internal class Zvire
    {
        // atributy třídy Zvire
        private string jmeno;
        private int vek;
        private int zdravi;
        // seznam zvirat kamaradici se zviretem
        private List<Zvire> kamaradi = new List<Zvire>();


        public List<Zvire> Kamaradi { get { return kamaradi; }  }
        public string Jmeno { get { return jmeno;} set { jmeno = value; } }
        public int Zdravi { get { return zdravi; } }

        //konstruktor třídy přijimající všechny atributy
        public Zvire(string jmeno, int vek, int zdravi)
        {
            this.jmeno = jmeno;
            this.vek = vek;
            this.zdravi = zdravi;
        }
        public void BFF(Zvire novyKamos)
        {
            kamaradi.Add(novyKamos);
            novyKamos.kamaradi.Add(this);
        }

        public string VypisKamaradu()
        {
            string k = "";
            foreach(Zvire kamos in kamaradi)
            {
                k += kamos + Environment.NewLine;
            }
            return k;
        }

        public void Doktor()
        {
            zdravi += 20;
            if (zdravi > 100) zdravi = 100;
        }

        // reimplementace výchozí funkce ToString()
        public override string ToString()
        {
            return $"{jmeno} (vek {vek} let) [+{zdravi}]";
        }
    }
}
