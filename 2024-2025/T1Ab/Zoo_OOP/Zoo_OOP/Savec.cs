using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_OOP
{
    class Savec : Zvire
    {
        private string barvaSrsti;
        public string BarvaSrsti { get { return barvaSrsti; } }
        public Savec(string name, double w, string srst) : base(name, w)
        {
            barvaSrsti = srst;
        }
        public override string ToString()
        {
            return base.ToString() + "[S]";
        }
    }
}
