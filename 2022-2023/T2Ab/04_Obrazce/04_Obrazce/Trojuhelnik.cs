using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Obrazce
{
    class Trojuhelnik : Obrazec
    {
        private double stranaA;
        private double stranaB;
        private double stranaC;

        public Trojuhelnik(double a, double b, double c)
        {
            stranaA = a;
            stranaB = b;
            stranaC = c;
        }

        public override double Obvod()
        {
            return stranaA + stranaB + stranaC;
        }

        public override double Obsah()
        {
            double s = Obvod() / 2;
            return Math.Sqrt(s * (s - stranaA) + s * (s - stranaB) + s * (s - stranaC));
        }

        public override string ToString()
        {
            return $"Trojuhlenik - S:{Obsah()}, o:{Obvod()}, barva:{Barva}";
        }
    }
}
