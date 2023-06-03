using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Poznamky
{
    internal class Aplikace
    {
        private List<Poznamka> seznamPoznamek = new List<Poznamka>();

        public List<Poznamka> SeznamPoznamek { get { return seznamPoznamek; } }

        public void PridatPoznamku(Poznamka p)
        {
            seznamPoznamek.Add(p);
        }

        public void OdeberPoznamku(Poznamka p)
        {
            seznamPoznamek.Remove(p);
        }

        public override string ToString()
        {
            string tmp = "";
            foreach (Poznamka p in seznamPoznamek)
            {
                tmp += p + Environment.NewLine;
            }
            return tmp;
        }
    }
}
