using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_OOP
{
    class Zvire
    {
        private string name;
        private int age;
        private double weight;

        public string Name {  get { return name; } }
        public int Age { get { return age; } set { age = value; } }
        public double Weight { get { return weight; } set { weight = value; } }

        public Zvire(string name, double w)
        {
            this.weight = w;
            this.name = name;
            this.age = 0;
        }

        public void Krmeni(int foodWeight)
        {
            weight += foodWeight / 3.0;
        }

        public string Pozdraveni()
        {
            return "jsem zvíře";
        }

        public void Starnuti()
        {
            age++;
        }

        // override říká, že reimplementujeme funkci z nadřazené třídy
        public override string ToString()
        {
            return $"{name} [{age}]";
        }
    }
}
