using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_procvicovaniOOP
{
    internal class Trojuhelnik : Obrazec
    {
        private double a;
        private double b;
        private double c;

        public Trojuhelnik(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Obsah()
        {
            double s = 2 * a + b + c;
            return s * (s - a) * (s - b) * (s - c);
        }

        public override double Obvod()
        {
            return a + b + c;
        }
    }
}
