using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakupniKosik
{
    class Zbozi
    {
        private string name;
        private double price;

        public string Name { get { return name; } }
        public double Price { get { return price; } }

        public Zbozi(string n, double p)
        {
            name = n;
            price = p;
        }

        public override string ToString()
        {
            return $"{name}-{price} Kč";
        }
    }
}
