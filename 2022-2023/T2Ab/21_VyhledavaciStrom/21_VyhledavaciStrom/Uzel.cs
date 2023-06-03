using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_VyhledavaciStrom
{
    internal class Uzel
    {
        private int hodnota;
        private Uzel rodic;
        private Uzel levy;
        private Uzel pravy;

        public Uzel Rodic { get { return rodic; } set { rodic = value; } }
        public Uzel Levy { get { return levy; } set { levy = value; } }
        public Uzel Pravy { get { return pravy; } set { pravy = value; } }
        public int Hodnota { get { return hodnota; } }

        public Uzel(int h)
        {
            hodnota = h;
        }

        public override string ToString()
        {
            return $"[ {hodnota} ]";
        }

    }
}
