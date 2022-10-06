using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Obrazce
{
    class Obdelnik : Obrazec
    {
        private double a;
        private double b;

        public Obdelnik(double stranaA, double stranaB)
        {
            a = stranaA;
            b = stranaB;
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
            return "Obdelnik- " + base.ToString();
        }
    }
}
