using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_OOP
{
    // dvojtečka říká, že třída uvedená vlevo rozšiřuje (dědí z) třídu napravo
    class Plaz : Zvire
    {
        private bool jedovaty;

        public bool Jedovaty { get { return jedovaty; }}
    
        // base umožňuje přístup k nadřazené třídě
        public Plaz(string name, int age, double weight,bool poisonous) : base(name,age,weight)
        {
            this.jedovaty = poisonous;
        }

        public void Pozdrav()
        {
            MessageBox.Show("Ciao");
        }

        public override string ToString()
        {
            return base.ToString() + $", jedovaty: {jedovaty}";
        }
    }
}
