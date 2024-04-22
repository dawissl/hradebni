using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnit
{
    public class Car
    {
       private string ridic;
       private int najezd;
       private double spotreba;

        public int Najezd { get { return najezd; } }

        public Car(string r,double s)
        {
            ridic = r;
            spotreba = s;
            najezd = 0;
        }

        public void Jizda(int km)
        {
            najezd += km;
        }

        public double CelkovaSpotreba()
        {
            // spotreba naprikla 6.4 l / 100 km
            return (najezd / 100.0) * spotreba;
        }
    }
}
