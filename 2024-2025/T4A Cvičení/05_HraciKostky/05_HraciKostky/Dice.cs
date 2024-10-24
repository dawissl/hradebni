using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_HraciKostky
{
    internal class Dice
    {
        private int side;
        private Color clr;

        public int Side { get { return side; } }
        public Color Clr { get { return clr; } }

        public Dice()
        {
            side = 6;
            clr = Color.White;
        }

        public Dice(int s, Color c)
        {
            if (s < 4) throw new ArgumentException("Invalid number of sides");
            side = s;
            clr = c;
        }

        public int Roll()
        {
            return new Random().Next(1, side + 1);
        }
        public override string ToString()
        {
            return $"D{side} - {clr}";
        }
    }
}
