using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Zoo
{
    internal class Krokodyl : Zvire
    {
        private double silaStisku;

        public Krokodyl(string jmeno, int vek, int zdravi, double silaStisku) : base(jmeno, vek, zdravi)
        {
            this.silaStisku = silaStisku;
        }

        public string Zautoc()
        {
            return "Jsem zlý krkodýl!!!";
        }
    }
}
