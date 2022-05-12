using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakupniKosik
{
    internal class Zbozi
    {
        private string name;
        private double price;
        private int count;
        public string Name { get { return name; } }
        public double Price { get { return price; } }
        public int Count { get { return count; } }
        public Zbozi(string n, double p, int c)
        {
            name = n;
            price = p;
            count = c;

         }

        public override string ToString()
        {
            return $"{name} - {count}x {price}Kč";
        }
    }
}
