using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakupniKosik
{
    internal class Potravina : Zbozi
    {
        private string storing;
        public string Storing { get { return storing; } }

        public Potravina(string n, double p,int c, string s) : base(n, p,c)
        {
            storing = s;
        }

        public override string ToString()
        {
            return base.ToString() + $"(skladování:{storing})";
        }
    }
}
