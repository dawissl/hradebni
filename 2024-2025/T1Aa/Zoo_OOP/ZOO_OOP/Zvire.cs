using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_OOP
{
    class Zvire
    {
        private string name;
        private int age;
        private double weight;

        public string Name { get { return name; } }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Zvire(string name, double w)
        {
            this.name = name;
            weight = w;
        }
        public void Starnuti()
        {
            age++;
        }
        public void Krmeni(int foodWeight)
        {
            weight += foodWeight / 3.0;
        }

        public override string ToString()
        {
            return $"{name} [{age}]";
        }
    }
}
