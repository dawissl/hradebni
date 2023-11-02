using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_procvicovaniOOP
{
    internal abstract class Obrazec
    {
        private Color barva;

        public Color Barva { get { return barva; } set { barva = value; } }

        public abstract double Obsah();
        public abstract double Obvod();

        public override string ToString()
        {
            return $"with area {Obsah()}j^2 and perimeter {Obvod()}j";
        }
    }
}
