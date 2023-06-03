using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Poznamky
{
    internal class Poznamka
    {
        private string nadpis;
        private DateTime datum;
        private string stitek;
        private Stav stav;

        public Stav UpravStav { get { return stav; } set { stav = value; } }

        public Poznamka(string nadpis)
        {
            this.nadpis = nadpis;
            datum = DateTime.Now;
            stitek = "";
            stav = Stav.OTEVRENY;
        }

        public Poznamka(string nadpis, string stitek)
        {
            this.nadpis = nadpis;
            datum = DateTime.Now;
            this.stitek = stitek;
            stav = Stav.OTEVRENY;
        }

        public override string ToString()
        {
            return $"{nadpis} [{datum}] ({stav})";
        }
    }

    public enum Stav { OTEVRENY, ZAVRENY};
}
