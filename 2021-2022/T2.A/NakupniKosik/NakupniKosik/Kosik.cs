using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakupniKosik
{
    internal class Kosik
    {
        private Zbozi[] nakup = new Zbozi[10];
        private int index = 0;

        public override string ToString()
        {
            string ret = "";
            for(int i = 0; i < index; i++)
            {
                ret += $"{nakup[i]}{Environment.NewLine}";
            }
            return ret;
        }
    }
}
