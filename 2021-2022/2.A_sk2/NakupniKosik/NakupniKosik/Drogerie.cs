using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakupniKosik
{
    class Drogerie : Zbozi
    {
        private string usedBy;
        public string UsedBy
        {
            get { return usedBy; }

        }

        public Drogerie(string n, double p, string u) : base(n, p)
        {
            usedBy = u;
        }

        public override string ToString()
        {
            return base.ToString()+$"(pro:{usedBy})";
        }
    }
}
