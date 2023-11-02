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

        public Color Barva { get {  return barva; } set {  barva = value; } }

        public Teleso()
        {
            barva = Color.White;
        }

        public abstract double Povrch();
        public abstract double Objem();

        public override string ToString()
        {
            return $"{barva} solid with surface {Povrch()}j^2 and volume {Objem()} j^3.";
        }
    }
}
