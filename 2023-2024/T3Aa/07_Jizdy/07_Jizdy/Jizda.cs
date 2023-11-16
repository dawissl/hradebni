using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Jizdy
{
    internal class Jizda
    {
        private DateTime datum;
        private string ridic;
        private string spz;
        private string naklad;
        public Jizda(DateTime datum, string ridic, string spz, string naklad)
        {
            this.datum = datum;
            this.ridic = ridic;
            this.spz = spz;
            this.naklad = naklad;
        }
        public override string ToString()
        {
            return $"Jizda ze dne {datum.ToShortDateString()}{Environment.NewLine}" +
                $"\t{ridic} {spz} {naklad}";
        }
        public string ToCsv()
        {
            return $"{datum.ToShortDateString()};{ridic};{spz};{naklad}";
        }
    }
}
