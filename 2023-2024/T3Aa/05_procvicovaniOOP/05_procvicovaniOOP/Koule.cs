using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_procvicovaniOOP
{
    internal class Koule : Teleso
    {
        private double r;
        public Koule(double r)
        {
            this.r = r;
        }
        public override double Objem()
        {
            return (4.0 / 3) * Math.PI * r * r*r;
        }

        public override double Povrch()
        {
            return 4 * Math.PI * r * r;
        }
    }
}
