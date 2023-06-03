using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Zoo
{
    internal class Zirafa : Zvire
    {
        private double vyska;

        public Zirafa(string jmeno, int vek, int zdravi,double vyska) : base (jmeno,vek,zdravi)
        {
            this.vyska = vyska;
        }
    }
}
