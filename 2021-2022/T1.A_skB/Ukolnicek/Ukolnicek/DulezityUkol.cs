using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukolnicek
{
    class DulezityUkol : Ukol
    {
        private string datum;
        public DulezityUkol(string n, string d) : base(n)
        {
            datum = d;
        }

        public override string ToString()
        {
            return base.ToString() + $" datum:{datum}";
        }
    }
}
