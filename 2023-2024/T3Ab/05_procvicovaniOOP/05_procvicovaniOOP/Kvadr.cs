using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_procvicovaniOOP
{
    internal class Kvadr : Teleso
    {
        private double a;
        private double b;
        private double c;

        public Kvadr(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Objem()
        {
            return a * b * c;
        }

        public override double Povrch()
        {
            return (2 * a * b) + (2 * b * c) + (2 * a * c);
        }

        public override string ToString()
        {
            return $"Cuboid " + base.ToString();
        }
    }
}
