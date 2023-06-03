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

        public List<Poznamka> Seznampoznamek { get { return seznamPoznamek; } }
        public void PridaniPoznamky(Poznamka p)
        {
            seznamPoznamek.Add(p);
        }

        public void OdebraniPoznamky(Poznamka p)
        {
            seznamPoznamek.Remove(p);
        }

        public override string ToString()
        {
            string vystup = "";
            foreach(Poznamka p in seznamPoznamek)
            {
                vystup += p + Environment.NewLine;
            }
            return vystup;
        }
    }
}
