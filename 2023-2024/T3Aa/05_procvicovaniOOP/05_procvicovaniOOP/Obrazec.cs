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
        public Color Barva { get {  return barva; }set { barva = value; } }

        public Obrazec()
        {
            barva = Color.White;
        }

        public abstract double Plocha();
        public abstract double Obvod();
        public override string ToString()
        {
            return $"{barva} pattern with area {Plocha()} and perimeter {Obvod()}";
        }
    }
}
