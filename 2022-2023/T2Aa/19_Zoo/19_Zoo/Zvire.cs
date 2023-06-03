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

        public void Doktor()
        {
            zdravi += 20;
            if (zdravi > 100) zdravi = 100;
        }

        public void BFF(Zvire z)
        {
            this.kamaradi.Add(z);
            z.kamaradi.Add(this);
        }

        public override string ToString()
        {
            return $"{jmeno} ({vek} let) [+{zdravi}]";
        }

        public string Animalbook()
        {
            string f = "";
            foreach(Zvire z in kamaradi)
            {
                f += z.ToString() + Environment.NewLine;
            }
            return f;

        }
    }
}
