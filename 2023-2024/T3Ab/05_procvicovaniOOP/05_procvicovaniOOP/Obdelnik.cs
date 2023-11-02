using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_procvicovaniOOP
{
    internal class Obdelnik : Obrazec
    {
        private double a;
        private double b;

        public Obdelnik(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Obsah()
        {
            return a * b;
        }

        public override double Obvod()
        {
            return 2 * a + 2 * b;
        }

        public override string ToString()
        {
            return $"Rectangle " + base.ToString();
        }
    }
}
