using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Obrazce
{
    class Obrazec
    {
        private Color barva;
        public Color Barva
        {
            get { return barva; }
            set { barva = value; }
        }
        public Obrazec()
        {
            barva = Color.White;
        }
        public virtual double Obvod()
        {
            return 0;
        }

        public virtual double Obsah()
        {
            return 0;
        }
    }
}
