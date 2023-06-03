using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Zoo
{
    internal class Zvire
    {
        private string jmeno;
        private int vek;
        private int zdravi;
        private List<Zvire> kamaradi = new List<Zvire>();

        public Zvire(string jmeno, int vek, int zdravi)
        {
            this.jmeno = jmeno;
            this.vek = vek;
            this.zdravi = zdravi;
        }

        public override string ToString()
        {
            return $"{jmeno} ({vek} let) [+{zdravi}]";
        }

        private int Zdravi { set { zdravi += value; if (zdravi > 100) zdravi = 100; } }

        public void Doktor()
        {
            zdravi += 20;
            if(zdravi > 100) { zdravi = 100; }
        }

        public void Doktor2()
        {
            Zdravi = 20;
        }

        public void BFF(Zvire z)
        {
            this.kamaradi.Add(z);
            z.kamaradi.Add(this);
        }

        public string VypisKamarady()
        {
            string k = "";

            foreach(Zvire bff in kamaradi)
            {
                k+= bff.ToString() + Environment.NewLine;
            }
            return k;
        }
    }
}
