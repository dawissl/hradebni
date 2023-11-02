using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_procvicovaniOOP
{
    internal class Koule : Teleso
    {
        private double polomer;

        public Koule(double r)
        {
            polomer = r;
        }

        public override double Objem()
        {
            return (4.0 / 3) * Math.PI * polomer * polomer * polomer;
        }

        public override double Povrch()
        {
            return 4 * Math.PI * polomer * polomer;
        }

        public override string ToString()
        {
            return $"Sphere " + base.ToString();
        }
    }
}
