using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NakupniKosik
{
    class Kosik
    {
        private Zbozi[] kosik = new Zbozi[10];
        private int index = 0;

        public void AddItem(Zbozi z)
        {
            if (index < 9)
            {
                kosik[index] = z;
                index++;
            }
            else
            {
                MessageBox.Show("Košík je plný!");
            }
            
        }

        public double TotalPrice()
        {
            double ret = 0;
            for (int i = 0; i < index; i++)
            {
                ret += kosik[i].Price;
            }
            return ret;
        }

        public override string ToString()
        {
            string ret = "";
            for(int i = 0; i < index; i++)
            {
                ret += kosik[i].ToString() + Environment.NewLine;
            }
            return ret;
        }
    }
}
