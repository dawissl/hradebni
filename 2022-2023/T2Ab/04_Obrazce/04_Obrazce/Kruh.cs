using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Obrazce
{
    class Kruh : Obrazec
    {
        private double polomer;

        public Kruh(double r)
        {
            polomer = r;
        }

        public override double Obsah()
        {
            return Math.PI * polomer * polomer;
        }

        public override double Obvod()
        {
            return Math.PI * 2 * polomer;
        }

        public override string ToString()
        {
            // $ = alt + 36
            return $"Kruh - S:{Obsah()}, o:{Obvod()}, barva:{Barva}";
        }
    }
}
