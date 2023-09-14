using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Iteratror
{
    internal class Zbozi
    {

        private double id;
        private string stringId;
        private string name;
        private double price;

        public Zbozi(double id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public Zbozi(string name, double price)
        {
            this.name = name;
            this.price = price;
            this.stringId = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"#{stringId} {name} - {price} Kč";
        }

        
    }
}
