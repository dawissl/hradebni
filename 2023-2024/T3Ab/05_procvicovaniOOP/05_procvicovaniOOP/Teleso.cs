using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_procvicovaniOOP
{
    internal abstract class Teleso
    {
        private Color barva;

        public Color Barva { get { return barva; } set { barva = value; } }

        public abstract double Povrch();
        public abstract double Objem();

        public override string ToString()
        {
            return $"with value {Objem()}j^3 and surface {Povrch()}j^2";
        }
    }
}
