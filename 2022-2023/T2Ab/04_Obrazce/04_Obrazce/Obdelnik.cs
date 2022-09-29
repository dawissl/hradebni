using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Obrazce
{
    class Obdelnik : Obrazec
    {
        private double stranaA;
        private double stranaB;

        public Obdelnik(double a, double b)
        {
            stranaA = a;
            stranaB = b;
        }

        public override double Obsah()
        {
            return stranaA * stranaB;
        }

        public override double Obvod()
        {
            return 2 * stranaB + 2 * stranaA;
        }
        public override string ToString()
        {
            return $"Obdelnik - S:{Obsah()}, o:{Obvod()}, barva:{Barva}";
        }
    }
}
