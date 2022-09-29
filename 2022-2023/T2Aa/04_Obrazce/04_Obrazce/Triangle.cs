using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Obrazce
{
    class Triangle:Obrazec
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double sA, double sB, double sC)
        {
            a = sA;
            b = sB;
            c = sC;
        }

        public override double Obsah()
        {
            double s = Obvod() / 2;
            return Math.Sqrt(s*(s-a)+s*(s-b)+s*(s-c)) ;
        }
        public override double Obvod()
        {
            return a+b+c;
        }
    }
}
