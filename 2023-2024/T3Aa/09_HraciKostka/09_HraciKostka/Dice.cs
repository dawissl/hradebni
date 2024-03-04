using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_HraciKostka
{
    internal class Dice
    {
        private int sides;
        private string label;
        private Color color;

        public string GetLabel { get { return label; } }
        public Color GetColor { get { return color; } }

        public Dice(int sides, string label, Color color)
        {
            if (sides < 4)
                throw new ArgumentOutOfRangeException("Minimal count of sides is 4");
            else
                this.sides = sides;
            this.label = label;
            this.color = color;
        }

        public int Roll()
        {
            return new Random().Next(1, sides + 1);
        }
    }
}
