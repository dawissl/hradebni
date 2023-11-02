using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_procvicovaniOOP
{
    internal class Krychle : Kvadr
    {
        public Krychle(double a) : base(a, a, a)
        {
        }

        public override string ToString()
        {
            return $"Cube with value {Objem()}j^3 and surface {Povrch()}j^2";
        }
    }
}
