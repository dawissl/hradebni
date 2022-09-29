using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Obrazce
{
    class Kruh : Obrazec
    {
        private double r;

        public Kruh(double polomer)
        {
            r = polomer;
        }

        public override double Obsah()
        {
            return Math.PI * r * r;
        }

        public override double Obvod()
        {
            return 2 * Math.PI * r;
        }

        public override string ToString()
        {
            return $"Kruh - S:{Obsah()}, o:{Obvod()}";
        }
    }
}
