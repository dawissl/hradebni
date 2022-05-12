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

        public void PridejZbozi(Zbozi z)
        {
            if(z == null)
            {
                MessageBox.Show("Neplatné zboží");
                return;
            }
            if(index < 9)
            {
                nakup[index] = z;
                index++;
            }
            else
            {
                MessageBox.Show("nakupni kosik je jiz plny!");
            }
        }

        public double TotalPrice()
        {
            double ret = 0;
            for (int i = 0; i < index; i++)
            {
                ret += nakup[i].Price * nakup[i].Count;
            }
            return ret;
        }

        public override string ToString()
        {
            string ret = "";
            for (int i = 0; i < index; i++)
            {
                ret += nakup[i].ToString()+Environment.NewLine;
            }
            return ret;
        }
    }
}
