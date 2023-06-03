using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Poznamky
{
    internal class Seznam : Poznamka
    {
        private List<string> seznamPolozek = new List<string>();

        public Seznam(string nadpis, string stitek) : base(nadpis, stitek)
        {

        }
        public Seznam(string nadpis) : base(nadpis)
        {

        }
    }
}
