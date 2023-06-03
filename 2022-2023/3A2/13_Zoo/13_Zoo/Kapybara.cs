using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Zoo
{
    internal class Kapybara : Zvire
    {
        public Kapybara(string jmeno, int vek, int zdravi) : base(jmeno, vek, zdravi)
        {           
        }

        public override string ToString()
        {
            return base.ToString() + "jsem vesela kapybara";
        }
    }
}
