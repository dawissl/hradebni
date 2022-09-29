using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
            barva = Color.Green;
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
