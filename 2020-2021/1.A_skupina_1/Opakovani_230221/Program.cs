using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ciselne hodnoty
            // int/short/long - cela cisla
            // double/float - desetinna cisla

            // datovy typ POJMENOVANI = prirazena hodnota
            int a = 20;
            int b = 30;
            // datovy typ POJMENOVANI
            int c;

            // c = 20 + 30 -> c = 50
            c = a + b;

            int neco = new int[] { 1, 3, 5 }.Length;

            string text = Console.ReadLine();

            // datovy typ A musi byt stejny jako datovy typ B
            // A = B


            double x = 1.8;
            double y = -3.6;
            double z;
            // z = 1.8 - (-3.6) -> z = 5.4
            z = x - y;

            double xx = z + 89;

            // nacteni z konzole
            // string = string
            string xyz = Console.ReadLine();


            int tmp = Convert.ToInt32(1.8); // tmp = 1;

            int tmp2 = int.Parse("2"); // tmp2 = 2;

            double tmp3 = int.Parse("1.36");

            int tmp4 = (int)21.786;

            // retezce/znaky

            char pismeno = 'H';
            char pismeno1 = char.Parse("H");
            char pismeno2 = Convert.ToChar("L");

            string ret1 = "ahoj";
            string ret2 = "svete";

            string ret3;
            ret3 = ret1 + " " + ret2 + ".";

            // pravdivostni hodnoty

            bool res = false;
            bool res1 = true;

            bool res2 = bool.Parse("true");

            //////////////////////////////////////////////////////////

            // POLE
            // 0,1,2,3,4,5
            int[] pole = new int[] { 8, 5, 6, 4, 6, 3 };
            pole[3] = 200; // ->{ 8, 5, 6, 200, 6, 3 }

            int stranaA = 25;
            int stranaB = 3;
            int stranaC = 17;

            int[] trojuhelnik = new int[3];
            trojuhelnik[0] = stranaA;
            trojuhelnik[1] = stranaB;
            trojuhelnik[2] = stranaC;

            int delkaPole = trojuhelnik.Length;

            ///
            // bool -> false/true
            // a > 10
            if (/*podminka*/) //             (a%2) == 0
            {
                // podminka je splnena - podminka je true
            }
            else
            {
                // podminka neni splena - podminka je false
            }


            // cykly
            do
            {
                // telo cyklu
            } while (/* a != 0*/); // -> dokud je podminka plata (true) opakuj se

            while (/*podminka*/) { };

            //     ridici promenna ; podminka ; uprava ridici promenne
            for (int tmp80 = 50; tmp80 > 0; tmp80 = tmp80 - 12)
            {

            }

            foreach ()
            {

            }

        }
    }
}
