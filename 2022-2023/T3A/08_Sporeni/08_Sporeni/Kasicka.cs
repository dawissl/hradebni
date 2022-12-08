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
            obalkaList.Add(new Obalka(100, "Výchozí obálka"));
            money = 0;
        }

        internal void VlozitObalku(Obalka ob)
        {
            int procentaNavic = 0;
            int odectenaProcenta = ob.Percent / obalkaList.Count;
            foreach (Obalka o in obalkaList)
            {
                if (o.Percent - odectenaProcenta <= 0)
                {
                    procentaNavic += (odectenaProcenta - 1);
                    o.Percent = 1;

                }

                else
                    o.Percent -= odectenaProcenta;
            }

            while (procentaNavic > 0)
            {
                odectenaProcenta = procentaNavic / obalkaList.Count;
                foreach (Obalka o in obalkaList)
                {
                    if (o.Percent - odectenaProcenta > 1)
                    {
                        o.Percent -= odectenaProcenta;
                        procentaNavic -= odectenaProcenta;
                    }

                }

            }
            obalkaList.Add(ob);

        }

        internal void VlozitPenize(int m)
        {
            Money = m;
            double onePercente = m / 100;

            foreach (Obalka o in obalkaList)
            {
                o.Money = onePercente * o.Percent;
            }
        }
    }
}
