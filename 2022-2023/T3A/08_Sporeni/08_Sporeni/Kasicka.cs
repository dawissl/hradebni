using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Sporeni
{
    internal class Kasicka
    {
        private List<Obalka> obalkaList;
        private double money;

        public List<Obalka> ObalkaList { get { return obalkaList; } }
        public double Money { get { return money; } set { money += value; } }

        public Kasicka()
        {
            obalkaList = new List<Obalka>();
            money = 0;
        }
    }
}
