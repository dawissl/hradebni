using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Zoo
{
    internal class Gepard : Zvire
    {
        private double rychlost;

        public double Rychlost { get { return rychlost; } set { rychlost = value; } }

        public Gepard(string jmeno, int vek, int zdravi, double rychlost) : base(jmeno, vek, zdravi)
        {
            this.rychlost = rychlost;
        }

        public string Spanek()
        {
            return "Zzzz...";
        }
    }
}
