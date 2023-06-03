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
        private string text;
        private DateTime datumZalozeni;
        private DateTime datumPlneni;
        private string stitek;
        private bool pripnuti;
        private Stav stav;

        public Stav StavUkolu { get { return stav; } set { stav = value; } }

        public Poznamka(string nadpis, string text, DateTime datumPlneni, string stitek)
        {
            this.nadpis = nadpis;
            this.text = text;
            datumZalozeni = DateTime.Now;
            this.datumPlneni = datumPlneni;
            this.stitek = stitek;
            pripnuti = false;
            stav = Stav.OTEVRENO;
        }

        public Poznamka(string nadpis, string text,string stitek)
        {
            this.nadpis = nadpis;
            this.text = text;
            datumZalozeni = DateTime.Now;
            this.stitek = stitek;
            pripnuti = false;
            stav = Stav.OTEVRENO;
        }

        public override string ToString()
        {
            return $"{nadpis}\n\r{text}\n\r[{stav}]";
        }
    }
    public enum Stav { OTEVRENO, SPLNENO, ARCHIVOVANO};
}
