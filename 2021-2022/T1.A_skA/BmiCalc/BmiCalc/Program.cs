using System;

namespace BmiCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulačka BMI");
            // načtení váhy a výšky
            Console.Write("Zadejte výšku[m]:");
            double vyska = double.Parse(Console.ReadLine());
            Console.Write("Zadejte váhu[kg]:");
            double vaha= double.Parse(Console.ReadLine());
            // získání hodnoty BMI
            double vysledekBmi = BmiCalcul(vaha, vyska);
            // vypsání hodnoty na výstup
            Console.WriteLine($"Hodnota BMI: {vysledekBmi}");
            Console.WriteLine($"Status: {VypsatVysledek(vysledekBmi)}");
        }

        private static string VypsatVysledek(double bmi)
        {
            Stav status = Stav.PODVAHA;
            if (bmi <= 20) status = Stav.PODVAHA;
            if (bmi > 20 && bmi <= 25) status = Stav.NORMALNI_STAV;
            if (bmi > 25 && bmi <= 30) status = Stav.MIRNA_OBEZITA;
            if (bmi > 30 && bmi <= 40) status = Stav.STREDNI_OBEZITA;
            if (bmi > 40) status = Stav.TEZKA_OBEZITA;

            return status.ToString();

           /* switch (status)
            {
                case Stav.PODVAHA:
                    return "Pozor, podváha!";
                case Stav.NORMALNI_STAV:
                    return "Normální stav";
                case Stav.MIRNA_OBEZITA:
                    return "Lehký případ obezity";
                case Stav.STREDNI_OBEZITA:
                    return "Střední případ obezity";
                case Stav.TEZKA_OBEZITA:
                    return "Pozor, vysoká obezita!";
                default:
                    return "Neznamý stav";
            }*/
        }


        private static double BmiCalcul(double vaha,double vyska)
        {
            if (vaha < 0) throw new Exception("Váha nesmí být záporná!");
            if (vyska <= 0) throw new Exception("Výšak musí být větší než 0!");
            return vaha / (vyska * vyska);
        }

        enum Stav { PODVAHA,NORMALNI_STAV,MIRNA_OBEZITA,
            STREDNI_OBEZITA,TEZKA_OBEZITA};
    }
}
