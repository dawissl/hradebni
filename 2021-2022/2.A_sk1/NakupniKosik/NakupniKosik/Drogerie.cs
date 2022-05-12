using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakupniKosik
{
    internal class Drogerie : Zbozi
    {
        private string usedBy;
        public string UsedBy { get { return usedBy; } }

        public Drogerie(string n, double p,int c, string u) : base(n, p,c)
        {
            usedBy = u;
        }

        public override string ToString()
        {
            return base.ToString() + $"(určeno pro:{usedBy})";
        }
    }
}
