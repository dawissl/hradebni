using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    internal class Dice
    {
        private int sides;
        private string label;
        private Color clr;

        public Color GetColor {  get { return clr; } }
        public string GetLabel {  get { return label; } }
        public Dice(int s, string l, Color c)
        {
            if (s < 4)
                throw new ArgumentException("Number of sides has to be higher or equal 4");
            else
                sides = s;
            label = l;
            clr = c;
        }

        public int Roll()
        {
            return new Random().Next(1, sides + 1);
        }

       public override string ToString()
        {
            return $"{label} D{sides}";
        }
    }
}
