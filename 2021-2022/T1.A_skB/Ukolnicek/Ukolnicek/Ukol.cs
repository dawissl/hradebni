using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukolnicek
{
    class Ukol
    {
        private string nazev;
        private bool splneno;

        public Ukol(string n)
        {
            nazev = n;
            splneno = false;
        }

        public override string ToString()
        {
            if (splneno)
            {
                return $"{nazev} (+)";
            }
            else
            {
                return $"{nazev} (-)";
            }
        }
    }
}
