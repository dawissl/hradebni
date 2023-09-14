using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Adersar
{
    internal class Kontakt
    {
        private string jmeno;
        private string prijmeni;
        private string mail;
        private string telefon;

        public string Surname { get { return prijmeni; } }

        public Kontakt(string jmeno, string prijmeni, string mail, string telefon)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.mail = mail;
            this.telefon = telefon;
        }

        public Kontakt(string jmeno, string prijmeni, string mail)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.mail = mail;
            telefon = "-";
        }

        public string ToCsv()
        {
            // $ = alt + 36
            return $"{jmeno};{prijmeni};{mail};{telefon}";
        }

        public override string ToString()
        {
            return $"{jmeno} {prijmeni}{Environment.NewLine}E:{mail}{Environment.NewLine}T:{telefon}";
        }
    }
}
