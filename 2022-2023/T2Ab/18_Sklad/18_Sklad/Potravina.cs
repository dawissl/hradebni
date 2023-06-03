using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Sklad
{
    internal class Potravina : Zbozi
    {
        private string trvanlivost;

        public Potravina(string n, string j, double m, string t) : base(n,j,m)
        {
            trvanlivost = t;
        }

        public override string ToString()
        {
            return base.ToString() + $" expirace[{trvanlivost}] ";
        }
    }
}
