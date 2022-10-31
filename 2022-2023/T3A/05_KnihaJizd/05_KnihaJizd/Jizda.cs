using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_KnihaJizd
{
    internal class Jizda
    {
        private string ridic;
        private string zbozi;
        private string vozidlo;
        private string datum;
        private string spzVozidla;

        public string Ridic { get { return ridic; } }
        /// TODO zbyle atributy
        /// 

        public Jizda(string _ridic, string _datum, string _zbozi, string _vozidlo, string _spz)
        {
            ridic = _ridic;
            zbozi = _zbozi;
            datum = _datum;
            vozidlo = _vozidlo;
            spzVozidla = _spz;
        }
    }
}
