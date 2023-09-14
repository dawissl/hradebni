using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Adresar
{
    internal class Kontakt
    {
        private string jmeno;
        private string prijmeni;
        private string email;
        private string telefon;

        public string Surename { get { return prijmeni; }}

        public Kontakt(string jmeno, string prijmeni, string email, string telefon)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.email = email;
            this.telefon = telefon;
        }

        public Kontakt(string jmeno, string prijmeni, string email)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.email = email;
            this.telefon = "-";
        }

        public string ToCsv()
        {
            //$ = alt + 36
            return $"{jmeno};{prijmeni};{email};{telefon}";
        }

        public override string ToString()
        {
            return $"{jmeno} {prijmeni}{Environment.NewLine}E:{email}{Environment.NewLine}T:{telefon}";   
        }
    }
}
